using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Filters;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using A4S.ERP.Infra.Repository.QueryExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context) { }

        public IQueryable<Produto> BuscarProdutosPorFiltro(BuscarProdutosFiltroFilter filter)
        {
            return Set
                .Include(p => p.InformacoesFiscais)
                    .ThenInclude(p => p.Unidades)
                .Include(p => p.Embalagem)
                    .ThenInclude(p => p.Unidades)
                .Include(p => p.Tributos)
                .FiltrarPorNomeProduto(filter.NomeProduto)
                .FiltrarPorDataCadastro(filter.DataCadastro)
                .FiltrarPorPreco(filter.Preco);
        }

        public override Produto BuscarPorGuid(Guid guid)
        {
            return Set.Include(p => p.InformacoesFiscais)
                    .ThenInclude(p => p.Unidades)
                .Include(p => p.InformacoesFiscais)
                    .ThenInclude(p => p.OrigemMercadoria)
                .Include(p => p.Embalagem)
                    .ThenInclude(p => p.Unidades)
                .Include(p => p.Tributos)
                .Include(p => p.GrupoProduto)
                .Include(p => p.Cor)
                .FirstOrDefault();
        }

        public void Importar(Stream csv)
        {
            StreamReader sr = new StreamReader(csv);

            while (sr.Peek() >= 0)
            {
                string[] campos = sr.ReadLine().Split(';');

                var found = Set.FirstOrDefault(x => x.NomeProduto == campos[0]);

                if (found == null)
                {
                    var produto = new Produto
                    {
                        NomeProduto = campos[6],
                        CodEan = campos[3],
                        CodFabricante = campos[29],
                        CodOriginal = campos[28],
                        Garantia = campos[30],
                        InformacoesFiscais = new InformacoesFiscais
                        {
                            PrecoCompra = campos[14].ToDecimal(),
                            PrecoVenda = campos[15].ToDecimal(),
                            Comissao = campos[33].ToDecimal(),
                            Cest = campos[49]

                        },
                        Tributos = new Tributos
                        {
                            Iva = campos[32].ToDecimal(),
                            Ipi = campos[16].ToDecimal(),
                            Icms = campos[17].ToDecimal(),
                            Cofins = campos[52],
                            Csosn = campos[41],
                            CodEnquadramentoIpi = campos[48],
                            CstPis = campos[34],
                            CstCofins = campos[36],
                            CstIpi = campos[37],
                            Pis = campos[51]
                        }
                    };

                    Set.Add(produto);

                    context.SaveChanges();
                }
            }
        }
    }
}
