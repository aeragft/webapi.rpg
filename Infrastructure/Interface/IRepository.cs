using System;
using System.Collections.Generic;

namespace Infrastructure.Interface
{
    interface IRepository<T>
    {
        T Find(int id);
        IEnumerable<T> Get();

        void Add(T write);
        T Remove(T write);
        T Update(T write);
    }
}
