<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
=======
﻿using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Enum;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
{
    public class EnvioEmail : Entity
    {
        public string Email { get; set; }
        public int PortSmtp { get; set; } = 587;
        public string SmtpCliente { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public bool IsOrigem { get; set; }
        public TipoEmail TipoEmail { get; set; }


        [IgnoreDataMember]
        public short IdEmpresa { get; set; }

        [IgnoreDataMember]
        public string Senha { get; set; }

        [IgnoreDataMember]
        public Empresa Empresa { get; set; }
    }
}
