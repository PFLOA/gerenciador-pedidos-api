using A4S.Core.Interfaces;

namespace A4S.Core
{
    public interface IRepository<TEntidade> : IBuscar<TEntidade>, IRepositoryBase<TEntidade>
    {

    }
    public interface IRepositoryBase<TEntidade> : IAdder<TEntidade>, IUpdater<TEntidade>, IRemover<TEntidade>
    {

    }
}
