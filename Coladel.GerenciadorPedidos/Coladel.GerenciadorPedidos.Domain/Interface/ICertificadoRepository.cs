using A4S.Core;
using A4S.ERP.Domain.Entidades;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace A4S.ERP.Domain.Interface
{
    public interface ICertificadoRepository : IRepository<Certificado>
    {
        Task<byte[]> SalvarBlob(IFormFile cert);
        string GerarHash(string senha);
        string ObterSenha(string hash);
    }
}
