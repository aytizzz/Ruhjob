﻿using Microsoft.AspNetCore.Mvc;
using Ruhjobsss.DataAccess.Context;
using Ruhjobsss.DataAccess.Entity;

namespace Ruhjobsss.Controllers
{
    public class JobController : Controller
    {
        private readonly AppDbContext _db;
        public JobController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.list = _db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Job j)
        {
            ViewBag.list = _db.Categories.ToList();

            j.CreateDate = DateTime.Now;
            _db.Add(j);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }









    }
}
