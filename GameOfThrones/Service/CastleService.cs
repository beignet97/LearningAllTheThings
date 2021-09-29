using GameOfThrones.DAL;
using GameOfThrones.Models;
using GameOfThrones.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones.Service
{
    public class CastleService
    {
        private protected WikiContext _context;
        private protected CastleRepository _repo;

        public CastleService()
        {
            _context = new WikiContext();
            _repo = new CastleRepository();
        }

        public List<Castle> GetCastles()
        {
            return _repo.GetAllCastles(_context);
        }
    }
}