namespace A4S.ERP.Domain.Entidades
{
    public class TipoCliente : EntityBase
    {
        public string Descricao { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
