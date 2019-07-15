using Core.Model;
using Infrastructure.Configuration;
using Infrastructure.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class SkillRepository : IRepository<Skill>
    {
        private readonly RpgContext _db;

        public SkillRepository(RpgContext db)
        {
            _db = db;
        }
    
        public void Add(Skill write)
        {
            if (write != null)
            {
                _db.Add(write);
                _db.SaveChanges();
            }
        }

        public Skill Find(int id) => _db
            .Characters.OfType<Skill>()
            .FirstOrDefault(s => s.ID == id);

        public IEnumerable<Skill> Get() => _db
            .Characters.OfType<Skill>()
            .ToList();

        public Skill Remove(Skill write)
        {
            if (write != null)
            {
                _db.Remove(write);
                _db.SaveChanges();
            }
            return write;
        }

        public Skill Update(Skill write)
        {
            if (write != null)
            {
                _db.Update(write);
                _db.SaveChanges();
            }
            return write;
        }
    }
}
