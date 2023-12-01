using System.Collections.Generic;

namespace A4S.ERP.Domain.Entidades
{
    public class Banco : EntityBase
    {
        public string Numero { get; set; }
        public string Nome { get; set; }

        public List<Conta> Contas { get; set; }
    }
}
