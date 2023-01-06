using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Enum;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
{
    public class EnvioEmail : Entity
    {
        public string Email { get; set; }
        public int PortSmtp { get; set; } = 587;
        public string SmtpCliente { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public bool IsOrigem { get; set; }
        public TipoEmail TipoEmail { get; set; }


        [IgnoreDataMember]
        public short IdEmpresa { get; set; }

        [IgnoreDataMember]
        public string Senha { get; set; }

        [IgnoreDataMember]
        public Empresa Empresa { get; set; }
    }
}
