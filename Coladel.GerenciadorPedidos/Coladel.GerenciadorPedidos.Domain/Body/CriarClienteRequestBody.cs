using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System.Collections.Generic;

namespace A4S.ERP.Domain.Body
{
    public class CriarClienteRequestBody
    {
        public string DocumentoSecundario { get; set; }
        public string DocumentoPrincipal { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Observacoes { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        public Endereco Endereco { get; set; }
        public IList<ContatoCliente> Contato { get; set; }

        public virtual Cliente ToModel() => new Cliente(this);
    }
}
