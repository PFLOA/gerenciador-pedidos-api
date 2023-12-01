<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
=======
﻿using Coladel.GerenciadorPedidos.Domain.Entidades;
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
using System;
using System.Collections.Generic;
using System.Text;

<<<<<<< HEAD
namespace A4S.ERP.Domain.Entidades
=======
namespace Coladel.GerenciadorAulas.Domain.Entidades
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
{
    public class Email : Entity
    {
        public short IdCliente { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
    }
}
