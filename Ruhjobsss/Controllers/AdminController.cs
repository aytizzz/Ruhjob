using Microsoft.AspNetCore.Mvc;
using Ruhjobsss.DataAccess.Context;

namespace Ruhjobsss.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _db;

        public AdminController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            var values = _db.Abouts.ToList();
            return View(values);
        }

        public IActionResult AboutDelete(int id)
        {
            _db.Remove(id);
            return RedirectToAction("About");
        }
    }
}
