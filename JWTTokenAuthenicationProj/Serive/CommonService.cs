using JWTTokenAuthenicationProj.Helpers;
using JWTTokenAuthenicationProj.Interfce;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace JWTTokenAuthenicationProj.Serive
{
    public class CommonService : ICommonService
    {
       
        static byte[] GenerateKey()
        {
            using var hmac = new HMACSHA256();
            return hmac.Key;
        }

        public string GetTokent(UserHelperModel helperModel)
        {
            var claims = new[]
           {
        new Claim(JwtRegisteredClaimNames.Sub, "JWTAccessToken"),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
        new Claim("UserId", helperModel.Id.ToString()),
        new Claim("UserName",helperModel.Username.ToString()),
        new Claim("Email", helperModel.Email.ToString()),
    };
            var key = GenerateKey();

            var a = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Convert.ToBase64String(key)));
            var singIn = new SigningCredentials(a, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                "JWTAuthendicationServer",
                "JWTServicePostmanClient",
                claims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: singIn
                );

            string tokens = new JwtSecurityTokenHandler().WriteToken(token);
            return tokens;
        }
    }
}
