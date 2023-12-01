using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Entidades.Response
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
