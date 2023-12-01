using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace A4S.ERP.Domain.Entidades
{
    public class Tributos : EntityBase
    {
        public decimal? CreditoIcms { get; set; }
        public decimal? Icms { get; set; }
        public decimal? Ipi { get; set; }
        public decimal? ReducaoIcms { get; set; }
        public decimal? ReducaoIcmsst { get; set; }
        public decimal? Iva { get; set; }

        public string Crt { get; set; }
        public string Irpj { get; set; }
        public string Pis { get; set; }
        public string Csll { get; set; }
        public string Cofins { get; set; }
        public string Iss { get; set; }
        public string Inss { get; set; }
        public string CstIpi { get; set; }
        public string CstIcms { get; set; }
        public string CstPis { get; set; }
        public string CstCofins { get; set; }
        public string Csosn { get; set; }
        public string CodEnquadramentoIpi { get; set; }
        public string ClasseEnquadramentoIpi { get; set; }
        public string NaturezaOperacao { get; set; }

        [IgnoreDataMember]
        public virtual Produto Produto { get; set; }
    }
}
