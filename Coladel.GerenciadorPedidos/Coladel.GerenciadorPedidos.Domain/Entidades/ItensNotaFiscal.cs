namespace A4S.ERP.Domain.Entidades
{
    public class ItensNotaFiscal : EntityBase
    {
        public short NotaFiscalId { get; set; }
        public short ProdutoId { get; set; }

        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }
    }
}
