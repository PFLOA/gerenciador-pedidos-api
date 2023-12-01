using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Interface
{
    public interface IUsuarioRepository
    {
        Usuario CriarUsuario(CriarUsuarioRequestBody usuario);
        string RetornarConnectionString();
    }
}
