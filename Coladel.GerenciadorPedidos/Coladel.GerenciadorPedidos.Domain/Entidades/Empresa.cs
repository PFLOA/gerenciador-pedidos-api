using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Empresa : Entity
    {
        public short EnderecoId { get; set; }
        public short BdEmpresaId { get; set; }
        public short TributosId { get; set; }

        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string TipoPessoa { get; set; }
        public string DocumentoPrincipal { get; set; }
        public string DocumentoSecundario { get; set; }
        public string Cnae { get; set; }
        public string Site { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoSuframa { get; set; }


        [IgnoreDataMember]
        public virtual List<Usuario> Usuarios { get; set; }

        public virtual List<Certificado> Certificados { get; set; }

        public virtual BdEmpresa BdEmpresa { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Tributos Tributos { get; set; }
    }
}
