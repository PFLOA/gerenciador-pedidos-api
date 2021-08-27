using Coladel.Core.Models;
using System;

namespace Coladel.GerenciadorPedidos.Domain.Filters
{
    public class BuscarProdutosFiltroFilter : BaseFilter
    {
        public string NomeProduto { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Preco { get; set; }
    }
}
