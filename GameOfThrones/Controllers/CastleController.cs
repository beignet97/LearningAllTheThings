using GameOfThrones.DAL;
using GameOfThrones.Models;
using GameOfThrones.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameOfThrones.Controllers
{
    public class CastleController : Controller
    {
        // private WikiContext db = new WikiContext();
        private CastleService service = new CastleService();

        // GET: Castle
        public ActionResult Index()
        {
            return View(service.GetCastles());
        }
    }
}