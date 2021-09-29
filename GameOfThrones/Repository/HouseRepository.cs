using GameOfThrones.DAL;
using GameOfThrones.Models;
using GameOfThrones.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones.Repository
{
    public class HouseRepository : IHouseRepository
    {
        public List<House> GetAllHouses(WikiContext context)
        {
            return context.Houses.ToList();
        }
    }
}