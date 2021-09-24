﻿using Coladel.Core.Models;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Filters
{
    public class BuscarPedidosFiltroFilter : BaseFilter
    {
        public StatusPedido StatusPedido { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string NF { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}