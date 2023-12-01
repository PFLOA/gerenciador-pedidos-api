namespace A4S.ERP.Domain.Entidades
{
    public class Email : Entity
    {
        public short IdCliente { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
    }
}
