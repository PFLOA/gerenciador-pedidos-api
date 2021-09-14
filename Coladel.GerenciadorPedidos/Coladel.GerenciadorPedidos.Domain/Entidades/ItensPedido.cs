using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class ItensPedido : Entity
    {
        [JsonIgnore]
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public short IdPedido { get; set; }
        public short IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
