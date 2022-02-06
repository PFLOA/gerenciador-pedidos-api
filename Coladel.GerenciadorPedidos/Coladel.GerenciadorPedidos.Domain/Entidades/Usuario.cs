using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ConnectionString { get; set; }
        public NivelAcesso Role { get; set; }

        public Usuario() { }
        public Usuario(object objetoMapping) => objetoMapping.MappingProperties(this);
        public Usuario(string nome, string senha, string userName, string email, Guid guid, NivelAcesso role)
        {
            Nome = nome;
            Senha = senha;
            UserName = userName;
            Email = email;
            Role = role;
            Guid = guid;
        }     
        
        public void CriptografarSenha()
        {

        }
    }
}
