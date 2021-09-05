using System;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class ItensPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
