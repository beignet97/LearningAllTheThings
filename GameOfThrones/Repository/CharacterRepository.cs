using GameOfThrones.DAL;
using GameOfThrones.Models;
using GameOfThrones.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        public List<Character> GetCharactersByHouse(WikiContext context, int? houseId)
        {
            return (from c in context.Characters
                    where c.HouseId.HouseId == houseId
                    select c).ToList();
        }
    }
}