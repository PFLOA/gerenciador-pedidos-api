using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using System;

namespace A4S.ERP.Application.Handlers.Produtos.Response
{
    public class BuscarProdutoPorGuidResponse
    {
        public Guid Guid { get; set; }
        public DateTime DataCadastro { get; set; }

        public string NomeProduto { get; set; }

        public virtual Cor Cor { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Tributos Tributos { get; set; }
        public virtual Embalagem Embalagem { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        public virtual GrupoProduto GrupoProduto { get; set; }
        public virtual SubGrupoProduto SubGrupoProduto { get; set; }
        public virtual InformacoesFiscais InformacoesFiscais { get; set; }

        public BuscarProdutoPorGuidResponse(Produto produto) => produto.MappingProperties(this);
    }
}
