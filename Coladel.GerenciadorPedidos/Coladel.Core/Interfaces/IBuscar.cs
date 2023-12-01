using System;

namespace A4S.Core.Interfaces
{
    public interface IBuscar<T>
    {
        T BuscarPorGuid(Guid guid);
    }
}
