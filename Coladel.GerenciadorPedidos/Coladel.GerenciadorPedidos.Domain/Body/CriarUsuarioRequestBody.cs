using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
    public class CriarUsuarioRequestBody
  {
    public string Nome { get; set; }
    public string Senha { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }

    public Usuario ToModel()
    {
        return new Usuario(this);
    }
  }
}
