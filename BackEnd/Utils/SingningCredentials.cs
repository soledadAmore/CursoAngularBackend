using Microsoft.IdentityModel.Tokens;

namespace BackEnd.Utils
{
    internal class SingningCredentials
    {
        private SymmetricSecurityKey securityKey;
        private object hmacSha256;

        public SingningCredentials(SymmetricSecurityKey securityKey, object hmacSha256)
        {
            this.securityKey = securityKey;
            this.hmacSha256 = hmacSha256;
        }
    }
}