﻿using GameOfThrones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameOfThrones.Controllers
{
    public class HouseController : Controller
    {
        private CastleContext db = new CastleContext();

        // GET: House
        public ActionResult Index()
        {
            return View(db.Houses.ToList());
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