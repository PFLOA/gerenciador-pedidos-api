using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorPedidos.Domain.Interface
{
    public interface ILoginRepository
    {
        Usuario LoginUser(string userName, string senha);
    }
}
