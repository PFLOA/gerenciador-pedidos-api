using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
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
