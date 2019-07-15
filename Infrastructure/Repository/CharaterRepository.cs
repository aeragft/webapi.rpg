using Core.Model;
using Infrastructure.Configuration;
using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class CharaterRepository : IRepository<Character>
    {
        private readonly RpgContext _db;

        public CharaterRepository(RpgContext db)
        {
            _db = db;
        }

        public void Add(Character write)
        {
           if(write != null)
            {
                _db.Add(write);
                _db.SaveChanges();
            }
        }

        public Character Find(int id) => _db
            .Characters.OfType<Character>()
            .FirstOrDefault(c => c.ID == id);

        public IEnumerable<Character> Get() => _db
            .Characters.OfType<Character>()
            .ToList();

        public Character Remove(Character write)
        {
            if(write != null)
            {
                _db.Remove(write);
                _db.SaveChanges();
            }
            return write;
        }

        public Character Update(Character write)
        {
            if(write != null)
            {
                _db.Update(write);
                _db.SaveChanges();
            }
            return write;
        }
    }
}
