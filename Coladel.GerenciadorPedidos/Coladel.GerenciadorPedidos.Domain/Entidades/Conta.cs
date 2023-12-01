using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Entidades
{
    public class Conta : EntityBase
    {
        public short BancoId { get; set; }

        public string NumAgencia { get; set; }
        public string NumConta { get; set; }
        public string Observacoes { get; set; }

        public TipoConta TipoConta { get; set; }

        public virtual Banco Banco { get; set; }
        public virtual CondicoesPagamento CondicoesPagamento { get; set; }
    }
}
