﻿using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;

namespace Coladel.Application.Handlers.Login.Response
{
    public class RealizarLoginResponse
    {
        public Guid Guid { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public RealizarLoginResponse(Usuario usuario, string token)
        {
            usuario.MappingProperties(this);
            Token = token;    
        }

    }
}
