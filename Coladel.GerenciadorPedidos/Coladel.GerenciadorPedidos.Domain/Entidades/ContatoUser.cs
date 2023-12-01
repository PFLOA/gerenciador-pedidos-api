namespace A4S.ERP.Domain.Entidades
{
    public class ContatoUser : EntityBase
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
