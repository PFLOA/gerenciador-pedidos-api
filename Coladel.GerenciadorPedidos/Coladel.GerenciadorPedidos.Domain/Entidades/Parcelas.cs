namespace A4S.ERP.Domain.Entidades
{
    public class Parcelas : EntityBase
    {
        public short CondicoesPagamentoId { get; set; }
        public int NumeroParcela { get; set; }
        public int Dias { get; set; }
        public decimal Rateio { get; set; }
        public decimal Acrescimo { get; set; }

        public virtual CondicoesPagamento CondicoesPagamento { get; set; }
    }
}
