﻿using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
    public class CriarProdutoRequestBody
    {
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public virtual Produto ToModel() => new Produto(this);
    }
}
