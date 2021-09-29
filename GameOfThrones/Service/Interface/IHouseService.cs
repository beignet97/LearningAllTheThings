using GameOfThrones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.Service.Interface
{
    interface IHouseService
    {
        List<House> GetHouses();
    }
}
