using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Body
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
