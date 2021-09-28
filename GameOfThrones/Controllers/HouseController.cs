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
    public class HouseController : Controller
    {
        private WikiContext db = new WikiContext();
        private HouseService service = new HouseService();

        // GET: House
        public ActionResult Index()
        {
            return View(service.GetHouses());
        }

        public ActionResult Characters(int? id)
        {
            var characters = from c in db.Characters
                             where c.HouseId.HouseId == id
                             select c;

            return View(characters);
        }
    }
}