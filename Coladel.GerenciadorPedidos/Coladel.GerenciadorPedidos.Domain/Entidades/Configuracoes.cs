<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
=======
﻿using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
{
    public class Configuracoes : Entity
    {
        public bool MostrarComissaoDashboard { get; set; }
        public bool EnviarEmailLogistica { get; set; }
        public bool EnviarEmailTransportadora { get; set; }

        [IgnoreDataMember]
        public virtual Empresa Empresa { get; set; }
    }
}
