using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories.Interface
{
    public interface IFactory<T>
    {
        T Create();
    }
}
