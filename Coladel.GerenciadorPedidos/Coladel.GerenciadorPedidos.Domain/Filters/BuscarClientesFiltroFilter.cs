using A4S.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4S.ERP.Domain.Filters
{
    public class BuscarClientesFiltroFilter : BaseFilter
    {
        /// <summary>
        /// Nome do cliente, pesquisa por aproximação.
        /// </summary>
        public string NomeCliente { get; set; }
        /// <summary>
        /// Data de cadastro do cliente ou clientes.
        /// </summary>
        public DateTime DataCadastro { get; set; }
    }
}
