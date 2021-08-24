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
        static IList<Task> taskList = new List<Task>
        {
            new Task() { TaskId = 1, TaskDescription = "Example task" }
        };

        public ActionResult Index()
        {
            return View(taskList.ToList());
        }

        [HttpPost]
        public ActionResult Index(FormCollection values)
        {
            var newTask = new Task() { TaskId = taskList.Count + 1, TaskDescription = values["TaskDescription"] };
            taskList.Add(newTask);

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