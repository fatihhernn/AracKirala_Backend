using Core.Entities.Concrete;
using Core.Utilities.Security.Encyption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            // bir algoritmayı kullanarak kendimize şifreli token oluşturcaz. token encrypt ederken kendi bildiğimiz özel bir anahtara ihtiyacımız var
            var securityKey = SecurityKeyHelper.CraeteSecurityKey(_tokenOptions.SecurityKey);

            //signingCredential bizim securityKey ve algoritmamızı belirlediğimiz classtır
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);

            // token oluşturmak istiyoruz => bu token bilgisi bilgisi, hangi kullanıcı için, hangi signingCredentials ile hangi rolleri içeriyorsa bunları parametre olarak verip bir adet token üretiyor olcaz

            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);

            //elimizdeki token bir handlar sayesinde yazdııralım
            var jwtSecuriytTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecuriytTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Expiration = _accessTokenExpiration,
                Token = token
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions,User user,SigningCredentials signingCredentials,List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user,operationClaims),
                signingCredentials: signingCredentials
                );

            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user,List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();

            //Claim gibi koleksiyonlara istediğimiz metodları oluşturmak için extension yazabiliriz
            claims.AddEmail(user.Email);
            claims.AddName($"{ user.FirstName}{user.LastName}");
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}
