using A4S.ERP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A4S.ERP.Infra.Repository.QueryExtensions
{
    public static class ClienteQueryExtension
    {

        public static IQueryable<Cliente> FiltrarPorNomeCliente(this IQueryable<Cliente> query, string nome)
        {
            if (!string.IsNullOrEmpty(nome)) return query.Where(p => p.RazaoSocial.ToLower().Contains(nome.ToLower()));
            return query;
        }
        public static IQueryable<Cliente> FiltrarPorDataCadastro(this IQueryable<Cliente> query, DateTime dataCadastro)
        {
            if (dataCadastro != DateTime.MinValue) return query.Where(p => p.DataCadastro.Date == dataCadastro.Date);
            return query;
        }
    }
}
