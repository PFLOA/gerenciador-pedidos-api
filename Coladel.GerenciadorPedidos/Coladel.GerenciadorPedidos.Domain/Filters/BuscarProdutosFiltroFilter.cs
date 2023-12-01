using A4S.Core.Models;
using System;

namespace A4S.ERP.Domain.Filters
{
    public class BuscarProdutosFiltroFilter : BaseFilter
    {
        public decimal? Preco { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
