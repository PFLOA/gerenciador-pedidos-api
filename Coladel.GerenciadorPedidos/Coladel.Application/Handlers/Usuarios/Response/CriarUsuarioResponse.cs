﻿using Coladel.Application.Handlers.Login.Handler.Usuarios.Request;
using Coladel.Core.Extensions;
using Coladel.Core.Utils;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Coladel.Application.Handlers.Usuarios.Response
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
