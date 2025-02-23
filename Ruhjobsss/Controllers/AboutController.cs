using Microsoft.AspNetCore.Mvc;
using Ruhjobsss.DataAccess.Context;

namespace Ruhjobsss.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        public AboutController(AppDbContext db)
        {
            _db = db;       
        }
        public IActionResult Index()
        {
            var values = _db.Abouts.ToList();
            return View(values);
        }
    }
}
