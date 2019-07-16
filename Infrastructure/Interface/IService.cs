using System.Collections.Generic;

namespace Infrastructure.Interface
{
    public interface IService<T>
    {
        T Save(T modelToAddToDB);

        T Update(int id, T modelToUpdate);

        T Delete(int id);

        T Get(int id);

        List<T> GetAll();

    }
}
