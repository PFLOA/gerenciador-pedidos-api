using A4S.Core.Models;

namespace A4S.ERP.Domain.Filters
{
    public class BuscarTransportadoraFilter : BaseFilter
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
    }
}
