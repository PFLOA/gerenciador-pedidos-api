using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorAulas.Domain.Body
{
    public class AlterarClienteRequestBody
    {
        public string NomeCliente { get; set; }
        public List<EmailRequestBody> EmailRequest { get; set; }
    }
}
