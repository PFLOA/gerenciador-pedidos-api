using A4S.ERP.Domain.Entidades;
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
        }
    }
}
