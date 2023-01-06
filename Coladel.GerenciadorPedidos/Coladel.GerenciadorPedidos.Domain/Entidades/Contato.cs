using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
{
    public class Contato : Entity
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }


        [IgnoreDataMember]
        public virtual Transportadora Transportadora { get; set; }
    }
}
