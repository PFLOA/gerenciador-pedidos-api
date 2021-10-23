using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions
{
    public static class ProdutoQueryExtension
    {
        public static IQueryable<Produto> FiltrarPorNomeProduto(this IQueryable<Produto> query, string nome)
        {
            if (!string.IsNullOrEmpty(nome)) return query.Where(p => p.NomeProduto.ToLower().Contains(nome.ToLower()));
            return query;
        }
        public static IQueryable<Produto> FiltrarPorDataCadastro(this IQueryable<Produto> query, DateTime dataCadastro)
        {
            if (dataCadastro != DateTime.MinValue) return query.Where(p => p.DataCadastro.Date == dataCadastro.Date);
            return query;
        }
        public static IQueryable<Produto> FiltrarPorPreco(this IQueryable<Produto> query, decimal? preco)
        {
            if (preco.HasValue) return query.Where(p => p.Preco == preco);
            return query;
        }
    }
}
