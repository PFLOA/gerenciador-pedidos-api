using A4S.Application.Handlers.Login.Handler.Usuarios.Request;
using A4S.Core.Extensions;
using A4S.Core.Utils;
using A4S.ERP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace A4S.Application.Handlers.Usuarios.Response
{
    public class CriarUsuarioResponse
    {
        public Guid Guid { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public CriarUsuarioResponse(Usuario usuario)
        {
            usuario.MappingProperties(this);
        }

        public Usuario ToUsuarioModel()
        {
            return new Usuario(this);
        }
    }
}
