using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Entidades
{
    public class ContatoCliente : EntityBase
    {
        public short ClienteId { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public TipoEmail TipoEmail { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
