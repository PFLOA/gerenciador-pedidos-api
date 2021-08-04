using Coladel.Application.Handlers.Login.Handler.Usuarios.Request;
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
        private string _senha;

        public Guid Guid { get; set; }
        public string Nome { get; set; }
        public string Senha
        {
            get
            {
                Hash hash = new Hash(SHA512.Create());
                string senha = hash.CriptografarSenha(_senha);

                string salt = Hash.CreateSalt(Guid.ToInt32());

                return $"{senha}{salt}";
            }
            set {
                _senha = value;
            }
        }
        public string UserName { get; set; }
        public string Email { get; set; }

        public CriarUsuarioResponse(Usuario usuario)
        {
            usuario.MappingProperties(this);
        }

        public Usuario ToUsuarioModel()
        {
            return new Usuario(Nome, Senha, UserName, Email, Guid);
        }
    }
}
