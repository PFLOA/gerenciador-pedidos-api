using System;

namespace A4S.Core.Interfaces
{
    public interface IUpdater<T>
    {
        short Alterar(T entidade);
    }
}
