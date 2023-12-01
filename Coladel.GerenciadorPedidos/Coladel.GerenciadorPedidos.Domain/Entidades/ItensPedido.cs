using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class ItensPedido : EntityBase
    {

        public short IdPedido { get; set; }
        public short IdProduto { get; set; }

        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        [IgnoreDataMember]
        public Pedido Pedido { get; set; }

        [IgnoreDataMember]
        public Produto Produto { get; set; }
    }
}
