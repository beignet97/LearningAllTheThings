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
        private HouseService houseService = new HouseService();
        private CharacterService characterService = new CharacterService();

        // GET: House
        public ActionResult Index()
        {
            return View(houseService.GetHouses());
        }

        public ActionResult Characters(int? id)
        {
            return View(characterService.GetCharactersByHouse(id));
        }
    }
}