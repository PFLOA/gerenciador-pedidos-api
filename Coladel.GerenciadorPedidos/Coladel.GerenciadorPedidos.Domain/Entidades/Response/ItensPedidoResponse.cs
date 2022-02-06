using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorAulas.Domain.Entidades.Response
{
    public class ItensPedidoResponse
    {
        public ItensPedidoResponse(ItensPedido item) { 
            item.MappingProperties(this);
            item.Produto?.MappingProperties(ProdutoResponse);
        }

        public ProdutoResponse ProdutoResponse { get; set; } = new ProdutoResponse();
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
