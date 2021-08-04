using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Produto : Entity<short>
    {
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
    }
}
