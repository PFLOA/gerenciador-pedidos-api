using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
    public class CriarProdutoRequestBody
    {
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }

        public Produto ToModel()
        {
            return new Produto
            {
                NomeProduto = NomeProduto,
                Preco = Preco
            };
        }
    }
}
