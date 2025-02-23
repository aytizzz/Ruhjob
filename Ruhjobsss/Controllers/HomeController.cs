using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ruhjobsss.DataAccess.Context;
using Ruhjobsss.Models;

namespace Ruhjobsss.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }


 
        public IActionResult Index()
        {

            ViewBag.c = _db.Categories.ToList();
            var values = _db.Jobs.ToList();
            return View(values);
        }

        public IActionResult Vacancy()
        {
            var values = _db.Jobs.ToList();
            return View(values);
        }
        public IActionResult Category()
        {
            var values = _db.Categories.ToList();
            return View(values);
        }


        public IActionResult Detail(int id)
        {
            if (id != null)
            {
                var values = _db.Jobs.Find(id);
                return View(values);
            }
            else
            {
                return Content("Bu elan movcud deyil");
            }

        }

        //public IActionResult GetJobsingle(string category)
        //{


        //    var jobs = _db.Jobs.
        //        Where(j =>j.Category.Name==category).ToList();
        //    return Ok(jobs);
        //}

        public IActionResult CategoryJob(int id)
        {
            var values = _db.Jobs.Where(x => x.CategoryID == id).ToList();
            return View(values);
        }
        
    }
}
