using GameOfThrones.DAL;
using GameOfThrones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameOfThrones.Controllers
{
    public class CastleController : Controller
    {
        private WikiContext db = new WikiContext();

        // GET: Castle
        public ActionResult Index()
        {
            return View(db.Castles.ToList());
        }
    }
}