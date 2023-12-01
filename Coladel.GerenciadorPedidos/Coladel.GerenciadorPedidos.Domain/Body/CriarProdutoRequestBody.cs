using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Body
{
    public class CriarProdutoRequestBody
    {
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public virtual Produto ToModel() => new Produto(this);
    }
}
