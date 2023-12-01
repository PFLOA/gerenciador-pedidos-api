using A4S.Core.Extensions;
using A4S.ERP.Domain.Body;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Produto : Entity
    {
        public short? GrupoId { get; set; }
        public short? SubGrupoId { get; set; }
        public short? CorId { get; set; }
        public short? EmabalagemId { get; set; }
        public short? FabricanteId { get; set; }
        public short? ModeloId { get; set; }
        public short? InformacoesFiscaisId { get; set; }
        public short? TributosId { get; set; }

        public string NomeProduto { get; set; }
        public string CodEan { get; set; }
        public string CodOriginal { get; set; }
        public string CodFabricante { get; set; }
        public string Garantia { get; set; }
        public string Observacoes { get; set; }

        public virtual Cor Cor { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Tributos Tributos { get; set; }
        public virtual Embalagem Embalagem { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        public virtual GrupoProduto GrupoProduto { get; set; }
        public virtual SubGrupoProduto SubGrupoProduto { get; set; }
        public virtual InformacoesFiscais InformacoesFiscais { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<ItensPedido> ItensPedido { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<ItensNotaFiscal> ItensNotaFiscal { get; set; }

        public Produto() { }
        public Produto(CriarProdutoRequestBody criarProdutoRequestBody) => criarProdutoRequestBody.MappingProperties(this);
    }
}
