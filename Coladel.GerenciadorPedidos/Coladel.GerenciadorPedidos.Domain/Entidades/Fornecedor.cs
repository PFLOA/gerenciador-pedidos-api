using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Entidades
{
    public class Fornecedor : Entity
    {
        public short ContatoId { get; set; }
        public short IdEndereco { get; set; }
        public string CodTransportadora { get; set; }
        public string NomeFantasia { get; set; }
        public string Observacao { get; set; }
        public string Website { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
    }
}
