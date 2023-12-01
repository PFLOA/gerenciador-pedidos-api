using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Filters;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using A4S.ERP.Infra.Repository.QueryExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(AppDbContext context) : base(context) { }

<<<<<<< HEAD
=======
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

>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
        public IQueryable<Pedido> BuscarPedidosPorFiltro(BuscarPedidosFiltroFilter filter) =>
            Set.FiltrarPorNomeCliente(filter.Cliente)
                .FiltrarPorData(filter.Mes, filter.Ano)
                .FiltrarPorDia(filter.Dia)
                .FiltrarPorStatus(filter.StatusPedido)
                .FiltrarPorGuid(filter.ClienteGuid)
                .OrderByDescending(p => p.DataCadastro)
<<<<<<< HEAD
                .Include(p => p.Cliente);
=======
                .Include(s => s.Cliente)
                .Include("ItensPedido.Produto");
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6

        public int BuscarTotalStatusPedidosPorFiltro(BuscarStatusPedidoFilter filter) => 
            Set.FiltrarPorAno(filter.Ano)
                .FiltrarPorMes(filter.Mes)
                .FiltrarPorStatus(filter.StatusPedido)
                .Count();

        public override Pedido BuscarPorGuid(Guid guid)
        {
            var obj = base.Set
                .Include(p => p.ItensPedido)
                .ThenInclude(p => p.Produto)
                .Include("Cliente")
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
