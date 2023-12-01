using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using System;

namespace A4S.Application.Handlers.Produtos.Response
{
    public class BuscarProdutosFiltroResponse
    {
        public short Id { get; set; }
        public string NomeProduto { get; set; }
        
        public Guid Guid { get; set; }
        public DateTime DataCadastro { get; set; }

        public Modelo Modelo { get; set; }
        public Embalagem Embalagem { get; set; }
        public Fabricante Fabricante { get; set; }
        public InformacoesFiscais InformacoesFiscais { get; set; }

        public BuscarProdutosFiltroResponse(Produto produto) => produto.MappingProperties(this);
    }
}
