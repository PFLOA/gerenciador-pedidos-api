using A4S.Application.Handlers.Login.Handler.Usuarios.Request;
using A4S.Application.Handlers.Usuarios.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Usuarios.Handler
{
  public class CriarUsuarioHandler : IRequestHandler<CriarUsuarioRequest, IActionResult>
  {
    private readonly IUsuarioRepository _usuarioRepository;

    public CriarUsuarioHandler(IUsuarioRepository usuarioRepository)
    {
      _usuarioRepository = usuarioRepository;
    }
    public async Task<IActionResult> Handle(CriarUsuarioRequest request, CancellationToken cancellationToken)
    {
      try
      {
        Usuario usuario = _usuarioRepository.CriarUsuario(request);
        return await Task.FromResult(new OkObjectResult(new { Usuario = new CriarUsuarioResponse(usuario) }));
      }
      catch (Exception ex)
      {
        return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
      }
    }
  }
}
