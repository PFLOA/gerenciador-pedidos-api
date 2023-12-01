using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace A4S.ERP.Infra.Repository.QueryExtensions
{
    public static class PedidoQueryExtension
    {
        public static IQueryable<Pedido> FiltrarPorNomeCliente(this IQueryable<Pedido> query, string nomeCliente)
        {
            if (string.IsNullOrEmpty(nomeCliente)) return query;

            return query.Where(p => p.Cliente.RazaoSocial.ToUpper().Contains(nomeCliente.ToUpper()));
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
            if (statusPedido.HasValue && statusPedido.Value == StatusPedido.TODOS) return query;

            if (statusPedido.HasValue) return query.Where(p => p.StatusPedido == statusPedido.Value);

            return query;
        }
<<<<<<< HEAD
        public static IQueryable<Pedido> FiltrarPorGuid(this IQueryable<Pedido> query, Guid? guid)
        {
            if (guid.HasValue) return query.Where(p => p.Cliente.Guid == guid.Value);

            return query;
        }
        public static IQueryable<Pedido> FiltrarPorDia(this IQueryable<Pedido> query, int? dia)
        {
            if (!dia.HasValue) return query;

            return query.Where(p => p.DataCadastro.Date.Day <= dia);
        }

        public static IQueryable<Pedido> FiltrarPorData(this IQueryable<Pedido> query, int? mes, int? ano)
        {
            if (!mes.HasValue || !ano.HasValue) return query;
=======
        public static IQueryable<Pedido> FiltrarPorDia(this IQueryable<Pedido> query, int dia)
        {
            if (dia == 0) return query;

            return query.Where(p => p.DataCadastro.Date.Day <= dia);
        }

        public static IQueryable<Pedido> FiltrarPorData(this IQueryable<Pedido> query, int mes, int ano)
        {
            if (mes == 0 || ano == 0) return query;
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6


            return query.Where(p => p.DataCadastro.Date.Month == mes).AsQueryable();
        }
    }
}
