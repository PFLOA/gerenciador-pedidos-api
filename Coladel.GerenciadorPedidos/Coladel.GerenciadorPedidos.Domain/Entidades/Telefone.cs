<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Entidades
=======
﻿using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorAulas.Domain.Entidades
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
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
