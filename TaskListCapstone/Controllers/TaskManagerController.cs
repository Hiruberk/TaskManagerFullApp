﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskListCapstone.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNet.Identity;

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
            TempData["UserId"] = User.Identity.Name;
            return View(_TaskManagerDB.ToDos.Where(x => x.UserId == User.Identity.GetUserId()).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo toDo)
        {
            toDo.UserId = User.Identity.GetUserId();

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
    }
}
