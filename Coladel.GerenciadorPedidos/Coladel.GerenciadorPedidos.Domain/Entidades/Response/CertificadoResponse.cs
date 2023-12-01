using System;

namespace A4S.ERP.Domain.Entidades.Response
{
    public class CertificadoResponse
    {
        public DateTime DataValidade { get; set; }
        public bool EmiteNfe { get; set; }
        public bool EmiteNfse { get; set; }
        public bool Padrao { get; set; }
    }
}
