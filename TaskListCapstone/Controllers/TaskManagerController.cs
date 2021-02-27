using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskListCapstone.Models;
using System.Security.Claims;

namespace TaskListCapstone.Controllers
{   [Authorize]
    public class TaskManagerController : Controller
    {
        private readonly TaskManagerContext _TaskManagerDB;

        public TaskManagerController(TaskManagerContext taskManagerContext)
        {
            _TaskManagerDB = taskManagerContext;
        }

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.Email);
            TempData["UserId"] = userId;
            return View(_TaskManagerDB.ToDos.ToList());
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
