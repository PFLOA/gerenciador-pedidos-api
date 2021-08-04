using System;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Usuario : Entity<short>
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public Usuario()
        {

        }
        public Usuario(string nome, string senha, string userName, string email, Guid guid)
        {
            Nome = nome;
            Senha = senha;
            UserName = userName;
            Email = email;
            Guid = guid;
        }
    }
}
