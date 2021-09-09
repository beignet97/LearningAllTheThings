using ExerciseMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseMVC.Controllers
{
    public class HomeController : Controller
    {
        private TaskDBContext db = new TaskDBContext();

        public ActionResult Index()
        {
            return View(db.Tasks.ToList());
        }

        [HttpPost]
        public ActionResult Index(FormCollection values)
        {
            var newTask = new Task() { TaskDescription = values["TaskDescription"], TaskDate = DateTime.Now };
            db.Tasks.Add(newTask);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}