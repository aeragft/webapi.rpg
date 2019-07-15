using Core.Model;
using Infrastructure.Configuration;
using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    class JobRepository : IRepository<Job>
    {

        private readonly RpgContext _db;

        public JobRepository(RpgContext db)
        {
            _db = db;
        }
        public void Add(Job write)
        {
           if(write != null)
            {
                _db.Add(write);
                _db.SaveChanges();
            }
        }

        public Job Find(int id) => _db
            .Jobs.OfType<Job>()
            .FirstOrDefault(j => j.ID == id);

        public IEnumerable<Job> Get() => _db
            .Characters.OfType<Job>()
            .ToList();

        public Job Remove(Job write)
        {
            if(write != null)
            {
                _db.Remove(write);
                _db.SaveChanges();
            }
            return write;
        }

        public Job Update(Job write)
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
