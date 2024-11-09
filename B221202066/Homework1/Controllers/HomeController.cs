using Microsoft.AspNetCore.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var announcements = Repository.Announcements;
            return View(announcements);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Announcement model)
        {
            Repository.Add(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var announcement = Repository.GetById(id);
            if (announcement == null)
            {
                return NotFound();
            }
            return View(announcement);
        }


    }
}
