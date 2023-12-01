using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades.Response;
using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Body
{
    public class ProdutoMaisVendidoBody
    {
        public decimal Total { get; set; }
        public int QuantidadeVendidaMes { get; set; }
        public decimal MediaPreco { get; set; }
        public decimal PrecoAtualProduto { get; set; }
        public decimal MaiorValorVendidoMes { get; set; }
        public string NomeProduto { get; set; }

        public ProdutoMaisVendidoBody()
        {

        }

        public ProdutoMaisVendidoBody(Produto produto, decimal total, int quantidade, decimal maiorValorVendidoMes)
        {
            Total = total;
            MaiorValorVendidoMes = maiorValorVendidoMes;
            QuantidadeVendidaMes = quantidade;
            MediaPreco = Total / QuantidadeVendidaMes;
            NomeProduto = produto.NomeProduto;
        }
    }
}
