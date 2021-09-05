using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions
{
    public static class PedidoQueryExtension
    {
        public static IQueryable<Pedido> FiltrarPorNomeCliente(this IQueryable<Pedido> query, string nomeCliente)
        {
            if (string.IsNullOrEmpty(nomeCliente)) return query;

            return query.Where(p => p.Cliente.NomeCliente.ToUpper().Contains(nomeCliente.ToUpper()));
        }
    }
}
