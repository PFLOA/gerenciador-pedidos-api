using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Interface
{
    public interface ILoginRepository
    {
        Usuario LoginUser(string userName, string senha);
    }
}
