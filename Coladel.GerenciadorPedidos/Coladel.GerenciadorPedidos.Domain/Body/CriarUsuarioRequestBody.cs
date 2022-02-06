using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Enum;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
    public class CriarUsuarioRequestBody
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public NivelAcesso Role { get; set; }

        public Usuario ToModel() => new Usuario(this);
    }
}
