using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.Core.Interfaces
{
    public interface IRemover<T>
    {
        Guid Remover(T entidade);
    }
}
