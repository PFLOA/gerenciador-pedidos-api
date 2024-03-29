﻿using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
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

        [IgnoreDataMember]
        public virtual Cliente ClienteCobranca { get; set; }

        [IgnoreDataMember]
        public virtual Cliente ClienteEntrega { get; set; }

        [IgnoreDataMember]
        public virtual Empresa Empresa { get; set; }
    }
}
