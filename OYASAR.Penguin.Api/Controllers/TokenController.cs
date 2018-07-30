using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using OYASAR.Penguin.Core.Model;
using OYASAR.Penguin.Core.Service;
using OYASAR.Framework.Core.Utils;

namespace OYASAR.Penguin.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/token")]
    [AllowAnonymous()]
    public class TokenController : ControllerBase
    {
        private readonly IUserService service;

        public TokenController()
        {
            service = Invoke<IUserService>.Call();
        }

        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            Console.WriteLine("User name:{0}", user.Username);
            Console.WriteLine("Password:{0}", user.Password);

            if (IsValidUserAndPassword(user))
                return new ObjectResult(GenerateToken(user.Username));

            return Unauthorized();
        }

        private string GenerateToken(string userName)
        {
            var someClaims = new Claim[]{
                new Claim(JwtRegisteredClaimNames.UniqueName,userName),
                new Claim(JwtRegisteredClaimNames.Email,"heimdall@mail.com"),
                new Claim(JwtRegisteredClaimNames.NameId,Guid.NewGuid().ToString())
            };

            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("uzun ince bir yoldayım şarkısını buradan tüm sevdiklerime hediye etmek istiyorum mümkün müdür acaba?"));
            var token = new JwtSecurityToken(
                issuer: "onuryasar.org",
                audience: "onuryasar.org",
                claims: someClaims,
                expires: DateTime.Now.AddMinutes(3),
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private bool IsValidUserAndPassword(User user)
        {
            return service.Login(user);
        }
    }
}