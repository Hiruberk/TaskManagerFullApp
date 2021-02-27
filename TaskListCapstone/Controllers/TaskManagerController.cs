using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskListCapstone.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace TaskListCapstone.Controllers
{   [Authorize]
    public class TaskManagerController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly TaskManagerContext _TaskManagerDB;
        private IdentityUser currentUser;

        public TaskManagerController(TaskManagerContext taskManagerContext, UserManager<IdentityUser> userManager)
        {
            _TaskManagerDB = taskManagerContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(UserManager<IdentityUser> userManager)
        {
            //var email = this.User.FindFirstValue(ClaimTypes.Email);
            //TempData["UserId"] = email;

            //var currentUser = await _userManager.GetUserAsync(User);
            IdentityUser currentUser = userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            return View(await _TaskManagerDB.ToDos.Where(x => x.User.Id == currentUser.Id).ToArrayAsync());

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo toDo)
        {
            if (ModelState.IsValid)
            {
                toDo.UserId = _userManager.GetEmailAsync(currentUser).ToString();
                var claims = _userManager.GetClaimsAsync(currentUser).ToString();
                _TaskManagerDB.ToDos.Add(toDo);
                _TaskManagerDB.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {

            ToDo toDo = _TaskManagerDB.ToDos.Find(id);

            return View(toDo);
        }

        [HttpPost]
        public IActionResult Delete(ToDo toDo)
        {
            if (ModelState.IsValid)
            {
                _TaskManagerDB.ToDos.Remove(toDo);
                _TaskManagerDB.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ToDo toDo = _TaskManagerDB.ToDos.Find(id);
            return View(toDo);
        }

        [HttpPost]
        public IActionResult Update(ToDo toDo)
        {
            toDo.UserId = _userManager.GetUserId(User);
            if (ModelState.IsValid)
            {
                _TaskManagerDB.ToDos.Update(toDo);
                _TaskManagerDB.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //public IActionResult Search(int CatId)
        //{
        //    Cat c = _catsDB.Cats.Find(CatId);
        //    return View(c);
        //}
    }
}
