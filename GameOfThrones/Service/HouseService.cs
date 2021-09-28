using GameOfThrones.DAL;
using GameOfThrones.Models;
using GameOfThrones.Repository;
using GameOfThrones.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones.Service
{
    public class HouseService : IHouseService
    {
        private protected WikiContext _context;
        private protected HouseRepository _repo;

        public HouseService()
        {
            _context = new WikiContext();
            _repo = new HouseRepository();
        }

        public House GetHouseById(int id)
        {
            return _repo.GetHouseById(_context, id);
        }

        public List<House> GetHouses()
        {
            return _repo.GetAllHouses(_context);
        }
    }
}