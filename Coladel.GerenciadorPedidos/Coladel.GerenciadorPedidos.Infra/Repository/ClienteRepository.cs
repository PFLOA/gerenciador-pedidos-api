<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Filters;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using A4S.ERP.Infra.Repository.QueryExtensions;
=======
﻿using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions;
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext dbContext) : base(dbContext) { }

        public IQueryable<Cliente> BuscarClientesPorFiltro(BuscarClientesFiltroFilter filter)
        {
            return Set.Include(p => p.Emails).FiltrarPorNomeCliente(filter.NomeCliente)
                    .FiltrarPorDataCadastro(filter.DataCadastro);
        }

        public override Cliente BuscarPorGuid(Guid guid)
        {
<<<<<<< HEAD
            var result = Set
                .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.PlanoContas)
                .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.MeioPagamento)
                .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.Parcelas)
                 .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.ContaDebitar)
                .Include(c => c.Endereco)
                .Include(c => c.EnderecoCobranca)
                .Include(c => c.EnderecoEntrega)
                .Include(c => c.RamoAtividade)
                .Include(c => c.TipoCliente)
                .Include(c => c.ContatosCliente)
                .Include(c => c.ContasReceber)
                .ThenInclude(cr => cr.Remessas)
                .First(p => p.Guid == guid);
=======
            var result = Set.Include(p => p.Emails).First(p => p.Guid == guid);
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
            return result;
        }
    }
}
