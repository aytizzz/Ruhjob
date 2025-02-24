using Microsoft.AspNetCore.Mvc;
using Ruhjobsss.DataAccess.Context;

namespace Ruhjobsss.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;

        public ContactController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var values = _db.Contacts.ToList();
            return View(values);
        }
    }
}
