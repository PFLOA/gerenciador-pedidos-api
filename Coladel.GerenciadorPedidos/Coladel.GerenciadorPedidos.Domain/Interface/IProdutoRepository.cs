using A4S.Core;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Filters;
using System.IO;
using System.Linq;

namespace A4S.ERP.Domain.Interface
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IQueryable<Produto> BuscarProdutosPorFiltro(BuscarProdutosFiltroFilter filter);
        void Importar(Stream csv);
    }
}
