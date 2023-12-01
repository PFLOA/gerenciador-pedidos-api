namespace A4S.ERP.Domain.Entidades
{
    public class Telefone : Entity
    {
        public short IdCliente { get; set; }
        public string Descricao { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public Cliente Cliente { get; set; }
    }
}
