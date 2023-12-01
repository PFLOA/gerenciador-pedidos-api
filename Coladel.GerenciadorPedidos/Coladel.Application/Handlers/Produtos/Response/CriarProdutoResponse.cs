﻿using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using System;

namespace A4S.Application.Handlers.Produtos.Response
{
    public class CriarProdutoResponse
    {
        public short Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public Guid Guid { get; set; }
        public DateTime DataCadastro { get; set; }

        public CriarProdutoResponse(Produto produto) => produto.MappingProperties(this);
    }
}
