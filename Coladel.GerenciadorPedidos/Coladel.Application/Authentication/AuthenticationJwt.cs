using System.Text;

namespace A4S.ERP.Authentication
{
    public static class AuthenticationJwt
    {
        public static byte[] InitConfigureJwtAuthetication(string jwtKeyConfiguratio)
        {
            return Encoding.ASCII.GetBytes(jwtKeyConfiguratio);
        }
    }
}
