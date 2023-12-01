using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A4S.ERP.Infra.Repository
{
    public class CertificadoRepository : UserRepository<Certificado>, ICertificadoRepository
    {
        private readonly IConfiguration _configuration;

        public CertificadoRepository(UserDbContext dbContext, IConfiguration configuration) : base(dbContext) { _configuration = configuration; }

        public string GerarHash(string senha)
        {
            string senhaRoot = _configuration.GetSection("RootCert").GetSection("PemPassPhrase").Value;
            byte[] entrada = Encoding.ASCII.GetBytes(senha);

            var certificado = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "certificado_validacao\\selfsigned.pfx");

            X509Certificate2 cert = new X509Certificate2(certificado, senhaRoot);

            RSA key = cert.GetRSAPrivateKey();

            byte[] encryptedDataBuffer = key.Encrypt(entrada, RSAEncryptionPadding.OaepSHA256);

            return Convert.ToBase64String(encryptedDataBuffer);
        }

        public string ObterSenha(string hash)
        {
            string senhaRoot = _configuration.GetSection("RootCert").GetSection("PemPassPhrase").Value;

            var certificado = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "certificado_validacao\\selfsigned.pfx");

            X509Certificate2 cert = new X509Certificate2(certificado, senhaRoot);

            RSA key = cert.GetRSAPrivateKey();

            byte[] hashByte = Convert.FromBase64String(hash);

            var decryptedData = key.Decrypt(hashByte, RSAEncryptionPadding.OaepSHA256);

            return Encoding.ASCII.GetString(decryptedData);
        }

        public async Task<byte[]> SalvarBlob(IFormFile cert)
        {
            using (var memoryStream = new MemoryStream())
            {
                await cert.CopyToAsync(memoryStream);

                if (memoryStream.Length < 2097152)
                {
                    return memoryStream.ToArray();
                }

                return null;
            }
        }
    }
}
