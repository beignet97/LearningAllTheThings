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
    public class CharacterService : ICharacterService
    {
        private protected WikiContext _context;
        private protected CharacterRepository _repo;

        public CharacterService()
        {
            _context = new WikiContext();
            _repo = new CharacterRepository();
        }

        public List<Character> GetCharactersByHouse(int? houseId)
        {
            return _repo.GetCharactersByHouse(_context, houseId);
        }
    }
}