namespace A4S.ERP.Domain.Entidades
{
    public class PlanoContas : EntityBase
    {
        public string Descricao { get; set; }
        public string Grupo { get; set; }
        public string TipoConta { get; set; }
        public bool IsCustoFixo { get; set; } 

        public virtual CondicoesPagamento CondicoesPagamento { get; set; }
    }
}
