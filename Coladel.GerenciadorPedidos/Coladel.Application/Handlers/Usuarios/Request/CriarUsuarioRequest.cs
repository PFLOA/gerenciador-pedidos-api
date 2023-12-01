using A4S.ERP.Domain.Body;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.Application.Handlers.Login.Handler.Usuarios.Request
{
    public class CriarUsuarioRequest : CriarUsuarioRequestBody, IRequest<IActionResult>
    {
    }
}
