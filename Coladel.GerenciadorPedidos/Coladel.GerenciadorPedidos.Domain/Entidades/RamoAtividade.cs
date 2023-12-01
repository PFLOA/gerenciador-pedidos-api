namespace A4S.ERP.Domain.Entidades
{
    public class RamoAtividade : EntityBase
    {
        public string Descricao { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
