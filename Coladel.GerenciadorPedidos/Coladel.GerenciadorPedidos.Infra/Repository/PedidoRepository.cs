using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions;
using Coladel.Infra.Repository.QueryExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(UserDbContext context) : base(context) { }

        public ProdutoMaisVendidoBody BuscarProdutoMaisVendidoMesAnoDados(int mes, int ano)
        {
            Produto produto = BuscarProdutoMaisVendido(mes, ano);

            if (produto is null) return new ProdutoMaisVendidoBody();

            var total = BuscarTotalProdutoMaisVendidoMes(mes, ano, produto);
            var quantidade = BuscarQuantidadeProdutoMaisVendidoMes(mes, ano, produto);
            var maxValorProdutoMes = BuscarAvgValorProdutoMaisVendidoMes(mes, ano, produto);

            return new ProdutoMaisVendidoBody(produto, total, quantidade, maxValorProdutoMes);
        }

        public Produto BuscarProdutoMaisVendido(int mes, int ano)
        {
            return FiltarListaItensPedido(mes, ano).FiltrarPorProdutoRecorrente();
        }

        public IQueryable<Pedido> BuscarPedidosPorFiltro(BuscarPedidosFiltroFilter filter) =>
            Set.FiltrarPorNomeCliente(filter.Cliente)
                .FiltrarPorData(filter.Mes, filter.Ano)
                .FiltrarPorDia(filter.Dia)
                .FiltrarPorStatus(filter.StatusPedido)
                .OrderByDescending(p => p.DataCadastro)
                .Include(s => s.Cliente)
                .Include("ItensPedido.Produto");

        public int BuscarTotalStatusPedidosPorFiltro(BuscarStatusPedidoFilter filter) => 
            Set.FiltrarPorAno(filter.Ano)
                .FiltrarPorMes(filter.Mes)
                .FiltrarPorStatus(filter.StatusPedido)
                .Count();

        public override Pedido BuscarPorGuid(Guid guid)
        {
            var obj = base.Set
                .Include(s => s.Cliente)
                .Include("ItensPedido.Produto")
                .FirstOrDefault(p => p.Guid == guid);

            return obj;
        }

        private List<ItensPedido> FiltarListaItensPedido(int mes, int ano)
        {
            List<ItensPedido> list = new List<ItensPedido>();

            var first = Set
                .Include(p => p.ItensPedido)
                .ThenInclude(p => p.Produto)
                .FiltrarPorMes(mes)
                .FiltrarPorAno(ano)
                .Where(p => p.StatusPedido == Domain.Enum.StatusPedido.ENTREGUE)
                .ToList();

            first.ForEach(p =>
            {
                list.AddRange(p.ItensPedido);
            });

            return list;
        }

        private decimal BuscarAvgValorProdutoMaisVendidoMes(int mes, int ano, Produto produto)
        {
            return FiltarListaItensPedido(mes, ano)
                .Where(b => b.Produto.Id == produto.Id)
                .Max(b => b.Preco);
        }
        private decimal BuscarTotalProdutoMaisVendidoMes(int mes, int ano, Produto produto)
        {
            return FiltarListaItensPedido(mes, ano)
                .Where(b => b.Produto.Id == produto.Id)
                .Sum(p => p.Preco * p.Quantidade);
        }

        private int BuscarQuantidadeProdutoMaisVendidoMes(int mes, int ano, Produto produto)
        {
            return FiltarListaItensPedido(mes, ano)
                .Where(b => b.Produto.Id == produto.Id)
                .Sum(p => p.Quantidade);
        }
    }
}
