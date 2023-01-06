using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorAulas.Domain.Entidades
{
    public class Email : Entity
    {
        public short IdCliente { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
    }
}
