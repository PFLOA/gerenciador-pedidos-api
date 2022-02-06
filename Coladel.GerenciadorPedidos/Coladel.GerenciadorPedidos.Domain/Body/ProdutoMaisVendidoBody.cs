using Coladel.Core.Extensions;
using Coladel.GerenciadorAulas.Domain.Entidades.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorPedidos.Domain.Body
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
            PrecoAtualProduto = produto.Preco;
            NomeProduto = produto.NomeProduto;
        }
    }
}
