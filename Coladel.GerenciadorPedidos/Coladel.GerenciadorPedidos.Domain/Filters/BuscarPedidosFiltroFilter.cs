<<<<<<< HEAD
﻿using A4S.ERP.Domain.Enum;
using A4S.Core.Models;
=======
﻿using Coladel.GerenciadorPedidos.Domain.Enum;
using Coladel.Core.Models;
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
using System;

namespace A4S.ERP.Domain.Filters
{
    public class BuscarPedidosFiltroFilter : BaseFilter
    {
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public int? Dia { get; set; }

        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string NF { get; set; }
<<<<<<< HEAD
        
        public Guid? ClienteGuid { get; set; }
        public StatusPedido? StatusPedido { get; set; }
=======
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
    }
}
