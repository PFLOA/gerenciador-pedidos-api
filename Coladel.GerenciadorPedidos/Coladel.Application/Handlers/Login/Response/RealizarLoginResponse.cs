using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;

namespace A4S.Application.Handlers.Login.Response
{
    public class RealizarLoginResponse
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public Role Role { get; set; }
        public Setor Setor { get; set; }

        public RealizarLoginResponse(Usuario usuario, string token)
        {
            usuario.MappingProperties(this);
            Token = token;
        }
    }
}
