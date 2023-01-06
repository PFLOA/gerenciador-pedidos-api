using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
{
    public class Empresa : Entity
    {
        [IgnoreDataMember]
        public short IdConfiguracao { get; set; }

        public string Nome { get; set; }
        public virtual List<EnvioEmail> EnvioEmails { get; set; }
        public virtual Configuracoes Configuracoes { get; set; }
    }
}
