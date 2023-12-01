using A4S.Core.Extensions;
using System;

namespace A4S.ERP.Domain.Entidades
{
    public class Usuario : Entity
    {
        public short? EmpresaId { get; set; }
        public short? ContatoUserId { get; set; }
        public short? RoleId { get; set; }
        public short? SetorId { get; set; }

        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public bool EmiteNfe { get; set; }

        public virtual Role Role { get; set; }
        public virtual Setor Setor { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ContatoUser ContatoUser { get; set; }

        public Usuario() { }
        public Usuario(object objetoMapping) => objetoMapping.MappingProperties(this);
        public Usuario(string nome, string senha, string userName, string email, Guid guid, Role role)
        {
            Nome = nome;
            Senha = senha;
            Email = userName;
            Email = email;
            Role = role;
            Guid = guid;
        }
    }
}
