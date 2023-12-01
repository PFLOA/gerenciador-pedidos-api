using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class InformacoesFiscais : EntityBase
    {
        public short? UnidadesId { get; set; }
        public short? OrigemMercadoriaId { get; set; }

        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal MargemLucro { get; set; }
        public decimal Comissao { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal PesoLiquido { get; set; }

        public string TipoItem { get; set; }
        public string Ncm { get; set; }
        public string Cest { get; set; }

        public virtual Unidades Unidades { get; set; }
        public virtual OrigemMercadoria OrigemMercadoria { get; set; }

        [IgnoreDataMember]
        public virtual Produto Produto { get; set; }
    }
}
