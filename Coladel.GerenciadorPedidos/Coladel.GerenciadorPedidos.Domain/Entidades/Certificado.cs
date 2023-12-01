using System;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Certificado : Entity
    {
        public short EmpresaId { get; set; }
        public byte[] CertificadoPrivado { get; set; }
        public string hash { get; set; }
        public DateTime DataValidade { get; set; }
        public bool EmiteNfe { get; set; }
        public bool EmiteNfse { get; set; }
        public bool Padrao { get; set; }

        [IgnoreDataMember]
        public Empresa Empresa { get; set; }
    }
}
