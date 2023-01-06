using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorAulas.Domain.Entidades
{
    public class Transportadora : Entity
    {
        public short? IdContato { get; set; }
        public short? IdEndereco { get; set; }
        public string CodTransportadora { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Observacao { get; set; }
        public string Website { get; set; }

        public virtual Contato Contato { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
