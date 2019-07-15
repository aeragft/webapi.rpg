using Core.Model;
using Infrastructure.Configuration;
using Infrastructure.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    class WeaponRepository : IRepository<Weapon>
    {
        private readonly RpgContext _db;

        public WeaponRepository(RpgContext db)
        {
            _db = db;
        }

        public void Add(Weapon write)
        {
            if(write != null)
            {
                _db.Add(write);
                _db.SaveChanges();
            }
        }

        public Weapon Find(int id) => _db
            .Characters.OfType<Weapon>()
            .FirstOrDefault(w => w.ID == id);

        public IEnumerable<Weapon> Get() => _db
            .Characters.OfType<Weapon>()
            .ToList();

        public Weapon Remove(Weapon write)
        {
            if (write != null)
            {
                _db.Remove(write);
                _db.SaveChanges();
            }
            return write;
        }

        public Weapon Update(Weapon write)
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
