<<<<<<< HEAD
﻿using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Entidades
{
    public class Contato : EntityBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public TipoEmail TipoEmail { get; set; }

        public virtual Transportadora Transportadora { get; set; }
        public virtual Cliente Cliente { get; set; }
=======
﻿using Coladel.GerenciadorPedidos.Domain.Entidades;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorAulas.Domain.Entidades
{
    public class Contato : Entity
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }


        [IgnoreDataMember]
        public virtual Transportadora Transportadora { get; set; }
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
    }
}
