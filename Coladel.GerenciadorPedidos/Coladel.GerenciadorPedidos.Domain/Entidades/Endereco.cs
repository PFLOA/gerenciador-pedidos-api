<<<<<<< HEAD
﻿using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
=======
﻿using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
{
    public class Endereco : Entity
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string  Cidade { get; set; }
        public string Estado { get; set; }

        [IgnoreDataMember]
        public virtual Transportadora Transportadora { get; set; }

        [IgnoreDataMember]
        public virtual Cliente Cliente { get; set; }
<<<<<<< HEAD

        [IgnoreDataMember]
        public virtual Cliente ClienteCobranca { get; set; }

        [IgnoreDataMember]
        public virtual Cliente ClienteEntrega { get; set; }

        [IgnoreDataMember]
        public virtual Empresa Empresa { get; set; }
=======
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
    }
}
