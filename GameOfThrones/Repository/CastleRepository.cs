using GameOfThrones.DAL;
using GameOfThrones.Models;
using GameOfThrones.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones.Repository
{
    public class CastleRepository : ICastleRepository
    {
        public List<Castle> GetAllCastles(WikiContext context) 
        {
            return context.Castles.ToList();
        }
    }
}