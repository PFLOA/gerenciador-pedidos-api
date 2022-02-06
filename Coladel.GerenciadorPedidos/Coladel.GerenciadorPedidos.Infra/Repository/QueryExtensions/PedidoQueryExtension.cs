using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions
{
    public static class PedidoQueryExtension
    {
        public static IQueryable<Pedido> FiltrarPorNomeCliente(this IQueryable<Pedido> query, string nomeCliente)
        {
            if (string.IsNullOrEmpty(nomeCliente)) return query;

            return query.Where(p => p.Cliente.NomeCliente.ToUpper().Contains(nomeCliente.ToUpper()));
        }
        
        public static IQueryable<Pedido> FiltrarPorMes(this IQueryable<Pedido> query, int mes)
        {
            if (mes == 0) return query.Where(p => p.DataCadastro.Month == DateTime.Now.Month);

            return query.Where(p => p.DataCadastro.Month == mes);
        }
        public static IQueryable<Pedido> FiltrarPorAno(this IQueryable<Pedido> query, int ano)
        {
            if (ano == 0) return query.Where(p => p.DataCadastro.Year == DateTime.Now.Year);

            return query.Where(p => p.DataCadastro.Year == ano);
        }
        public static IQueryable<Pedido> FiltrarPorStatus(this IQueryable<Pedido> query, StatusPedido? statusPedido)
        {
            if (statusPedido.HasValue) return query.Where(p => p.StatusPedido == statusPedido);

            return query;
        }
        public static IQueryable<Pedido> FiltrarPorDataCadastro(this IQueryable<Pedido> query, DateTime dataCadastro)
        {
            if (dataCadastro == DateTime.MinValue) return query;

            return query.Where(p => p.DataCadastro.Date == dataCadastro.Date);
        }
    }
}
