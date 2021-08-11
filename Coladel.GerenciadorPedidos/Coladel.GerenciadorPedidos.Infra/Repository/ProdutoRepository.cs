using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context) { }

        public Produto CriarProduto(CriarProdutoRequestBody produto)
        {
            var retorno = Set.Add(produto.ToModel());
            context.SaveChanges();

            return retorno.Entity;
        }
    }
}
