<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class EmpresaRepository : UserRepository<Empresa>, IEmpresaRepository
    {
        private readonly IHttpContextAccessor _httpContext;

        public EmpresaRepository(UserDbContext dbContext, IHttpContextAccessor httpContext) : base(dbContext) =>
            _httpContext = httpContext;

        public Empresa RetornarEmpresa()
        {
            short empresaId = Convert.ToInt16(_httpContext.HttpContext.User.Claims.Where(p => p.Type == "empresa_id").Select(p => p.Value).FirstOrDefault());

            return Set.Include(p => p.Certificados)
                .Include(p => p.Endereco)
                .Include(p => p.Tributos)
                .FirstOrDefault(p => p.Id == empresaId);
=======
﻿using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Coladel.Infra.Repository
{
    public class EmpresaRepository : Repository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(UserDbContext dbContext) : base(dbContext) { }

        public Empresa RetornarEmpresa()
        {
            return Set.Include(p => p.Configuracoes).Include(p => p.EnvioEmails).FirstOrDefault();
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
        }
    }
}
