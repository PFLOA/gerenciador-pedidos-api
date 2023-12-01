using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Entidades.Response;
using System.Collections.Generic;

namespace A4S.ERP.Application.Handlers.Empresas.Response
{
    public class BuscarEmpresaResponse
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string TipoPessoa { get; set; }
        public string DocumentoPrincipal { get; set; }
        public string DocumentoSecundario { get; set; }
        public string Cnae { get; set; }
        public string Site { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoSuframa { get; set; }

        public virtual List<CertificadoResponse> Cert { get; set; } = new List<CertificadoResponse>();
        public virtual Endereco Endereco { get; set; }
        public virtual Tributos Tributos { get; set; }

        public BuscarEmpresaResponse(Empresa empresa)
        {
            empresa.MappingProperties(this);
            empresa.Certificados.ForEach(e =>
            {
                var cert = new CertificadoResponse();
                e.MappingProperties(cert);

                Cert.Add(cert);
            });
        }
    }
}
