namespace A4S.ERP.Domain.Entidades.Response
{
    public class InformacoesFiscaisResponse
    {
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

        public Unidades Unidades { get; set; }
        public OrigemMercadoria OrigemMercadoria { get; set; }
    }
}
