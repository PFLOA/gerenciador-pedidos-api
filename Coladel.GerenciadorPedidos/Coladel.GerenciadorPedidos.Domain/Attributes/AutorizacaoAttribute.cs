using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Coladel.Domain
{
    public class AutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<NivelAcesso> _roles;

        public AutorizacaoAttribute(params NivelAcesso[] roles) => _roles = roles ?? new NivelAcesso[] { };

        public AutorizacaoAttribute() => _roles = new List<NivelAcesso>();

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous) return;

            var claims = context.HttpContext.User.Claims;
            var valor = claims.Where(p => p.Type == ClaimTypes.Role)
                            .Select(p => p.Value).FirstOrDefault();

            if (valor is null) context.Result = new JsonResult(new { message = "Não autorizado !" }) { StatusCode = StatusCodes.Status401Unauthorized }; ;

            var role = (NivelAcesso)Enum.Parse(typeof(NivelAcesso), valor);

            if (role == NivelAcesso.NoAccess) context.Result = new JsonResult(new { message = "Não autorizado !" }) { StatusCode = StatusCodes.Status401Unauthorized };

            if (claims is null || (_roles.Any() && !_roles.Contains(role)))
            {
                context.Result = new JsonResult(new { message = "Não autorizado !" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }

        }
    }
}
