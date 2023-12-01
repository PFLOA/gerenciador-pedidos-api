using A4S.ERP.Domain.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace A4S.Domain
{
    public class AutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<Role> _roles = new List<Role>();

        public AutorizacaoAttribute(params string[] roles)
        {
            foreach (var item in roles)
            {
                _roles.Add(new Role { Descricao = item });
            }
        }

        public AutorizacaoAttribute() => _roles = new List<Role>();

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous) return;

            var claims = context.HttpContext.User.Claims;
            var valor = claims.Where(p => p.Type == ClaimTypes.Role)
                            .Select(p => p.Value).FirstOrDefault();

            if (string.IsNullOrEmpty(valor)) context.Result = new JsonResult(new { message = "Não autorizado !" }) { StatusCode = StatusCodes.Status401Unauthorized }; ;

            if (claims is null || (_roles.Any() && !_roles.Contains(new Role { Descricao = valor })))
            {
                context.Result = new JsonResult(new { message = "Não autorizado !" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
