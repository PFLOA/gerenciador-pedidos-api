using System;
using System.IO;

namespace A4S.Core.Interfaces
{
    public interface IAdder<T>
    {
        T Criar(T entidade);
        void Importar(Stream arq);
        void Importar(Func<string[], T> func, Stream csv);
    }
}
