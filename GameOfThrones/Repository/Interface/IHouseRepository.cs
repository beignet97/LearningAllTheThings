using GameOfThrones.DAL;
using GameOfThrones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.Repository.Interface
{
    interface IHouseRepository
    {
        List<House> GetAllHouses(WikiContext context);
    }
}
