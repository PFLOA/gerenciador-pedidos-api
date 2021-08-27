using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context) { }

        public IQueryable<Produto> BuscarProdutosPorFiltro(BuscarProdutosFiltroFilter filter)
        {
            return Set.FiltrarPorNomeProduto(filter.NomeProduto)
                .FiltrarPorDataCadastro(filter.DataCadastro);
        }
        public Produto CriarProduto(CriarProdutoRequestBody produto)
        {
            var retorno = Set.Add(produto.ToModel());
            context.SaveChanges();

            return retorno.Entity;
        }
    }
}
