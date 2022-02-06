using Newtonsoft.Json;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class ItensPedido : Entity
    {
        [JsonIgnore]
        public Pedido Pedido { get; set; }
        [JsonIgnore]
        public Produto Produto { get; set; }
        public short IdPedido { get; set; }
        public short IdProduto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
