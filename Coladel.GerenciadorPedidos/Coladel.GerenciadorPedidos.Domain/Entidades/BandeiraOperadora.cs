namespace A4S.ERP.Domain.Entidades
{
    public class BandeiraOperadora : EntityBase
    {
        public string Descricao { get; set; }

        public virtual CondicoesPagamento CondicoesPagamento { get; set; }
    }
}
