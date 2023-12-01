using System;

namespace A4S.ERP.Domain.Entidades
{
    public class CobrancaNf : EntityBase
    {
        public int Duplicatas { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorLiquido { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }
    }
}
