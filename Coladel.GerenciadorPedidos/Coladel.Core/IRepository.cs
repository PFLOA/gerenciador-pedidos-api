using Coladel.Core.Interfaces;

namespace Coladel.Core
{
    public interface IRepository<TEntidade> : IAdder<TEntidade>, IDataService<TEntidade>, IFinder<TEntidade>, IUpdater<TEntidade>, IRemover<TEntidade>
    {

    }
}
