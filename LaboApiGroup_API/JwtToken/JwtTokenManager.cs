using LaboApiGroup_API.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LaboApiGroup_API.JwtToken
{
    public class JwtTokenManager
    {
        public static string secret = "OfOuYD2nzPUfL/WLz8JYDJIlhmVA8IbuO2o1vWzY8UOTG/gaVOaNNBar7hdX59USWfK7AzElt2cU+3JSNCrGRWOe/Vj169O1yRbMskpf1xAoDDSneLhmfYMQQRD+1WT66REh55hpdKsJuoFivlsIQtwN9Aq39H7ATI791QNI7RY=";
        public static string issuer = "mysite.com"; // Créateur du jeton
        public static string audience = "mysite.com";//

        public string GenerateToken(Users_C u)
        {
            if (u.Email is null) throw new ArgumentNullException();

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));//transforme le secret
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);//hashage des données
                                                                                                                // Création de l'objet de securité avec les infos a stocker => Claims
            Claim[] claims = new[]
            {
                new Claim("Id_Users", u.Id.ToString()),
                new Claim(ClaimTypes.Email, u.Email),
                new Claim(ClaimTypes.Role, (u.IsAdmin ? "admin" : "user" ))
            };

            // Generation du token => Nuget : System.IdentityModel.Tokens.Jwt
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
    }
}
