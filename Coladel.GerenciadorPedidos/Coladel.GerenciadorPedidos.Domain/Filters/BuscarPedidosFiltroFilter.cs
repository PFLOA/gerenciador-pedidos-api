using A4S.ERP.Domain.Enum;
using A4S.Core.Models;
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
        
        public Guid? ClienteGuid { get; set; }
        public StatusPedido? StatusPedido { get; set; }
    }
}
