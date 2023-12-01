using System.Collections.Generic;

namespace A4S.ERP.Domain.Body
{
    public class AlterarClienteRequestBody
    {
        public string NomeCliente { get; set; }
        public string Observacoes { get; set; }
        public List<EmailRequestBody> EmailRequest { get; set; }
    }
}
