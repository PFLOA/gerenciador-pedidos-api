using System;
using System.Collections.Generic;
using System.Text;

namespace A4S.Core.Interfaces
{
    public interface IRemover<T>
    {
        bool Remover(T entidade);
    }
}
