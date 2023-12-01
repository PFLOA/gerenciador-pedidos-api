using A4S.ERP.Domain.Entidades;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace A4S.ERP.JWT
{
    public static class RetornoJwt
    {
        public static string RetornoJwtString(Usuario result)
        {
            var secret = Encoding.ASCII.GetBytes("12b6fb24-adb8-4ce5-aa49-95a4sads4ad561sa");
            var symmetricSecurityKey = new SymmetricSecurityKey(secret);
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                   new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()),
                   new Claim("empresa_id", result.Empresa.Id.ToString()),
                   new Claim(ClaimTypes.Email, result.Email),
                   new Claim(ClaimTypes.Role, result.Role.Descricao.ToString()),
                   new Claim(ClaimTypes.Name, result.Nome),
                   new Claim(ClaimTypes.Uri, result.Empresa.BdEmpresa.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenGenerated = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

            return jwtSecurityTokenHandler.WriteToken(tokenGenerated);
        }
    }
}
