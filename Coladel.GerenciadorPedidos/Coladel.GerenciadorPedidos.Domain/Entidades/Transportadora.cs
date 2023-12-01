﻿using A4S.ERP.Domain.Enum;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Transportadora : Entity
    {
        public short ContatoId { get; set; }
        public short EnderecoId { get; set; }
        public string CodTransportadora { get; set; }
        public string NomeFantasia { get; set; }
        public string Observacao { get; set; }
        public string Website { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        public virtual Contato Contato { get; set; }
        public virtual Endereco Endereco { get; set; }

        [IgnoreDataMember]
        public virtual List<TransporteNf> TransporteNf { get; set; }
    }
}
