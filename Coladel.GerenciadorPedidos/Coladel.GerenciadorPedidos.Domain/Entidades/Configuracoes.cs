using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Configuracoes : Entity
    {
        public bool MostrarComissaoDashboard { get; set; }
        public bool EnviarEmailLogistica { get; set; }
        public bool EnviarEmailTransportadora { get; set; }

        [IgnoreDataMember]
        public virtual Empresa Empresa { get; set; }
    }
}
