using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coladel.Infra.Repository.QueryExtensions
{
    public static class ItensPedidoQueryExtension
    {
        public static IQueryable<ItensPedido> FiltrarPorMes(this IQueryable<ItensPedido> query, int mes)
        {
            if (mes == 0) return query.Where(p => p.DataCadastro.Month == DateTime.Now.Month);

            return query.Where(p => p.DataCadastro.Month == mes);
        }

        public static IQueryable<ItensPedido> FiltrarPorAno(this IQueryable<ItensPedido> query, int ano)
        {
            if (ano == 0) return query.Where(p => p.DataCadastro.Year == DateTime.Now.Year);

            return query.Where(p => p.DataCadastro.Year == ano);
        }

        public static Produto FiltrarPorProdutoRecorrente(this List<ItensPedido> query)
        {
            short lastCount = 0;
            short contagem = 0;
            long idOcorrido = 0;

            if (query.Count() == 0) return null;

            var listagem = query.Select(p => p.Produto)
                            .OrderBy(p => p.Id)
                            .ToList();

            for (int i = 0; i < listagem.Count(); i++)
            {

                long id = listagem[i].Id;

                if ((i + 1) == listagem.Count) {
                    if (idOcorrido == 0) idOcorrido = id;
                    break; 
                }

                long idNext = listagem[i + 1].Id;

                contagem++;

                if (id != idNext)
                {
                    if (contagem > lastCount)
                    {
                        lastCount = contagem;
                        idOcorrido = id;
                    }
                    contagem = 0;
                }
            }

            return listagem.First(p => p.Id == idOcorrido);
        }
    }
}
