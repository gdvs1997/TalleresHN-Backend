using BackendTalleresHN.Dominio.Models;
using BackendTalleresHN.Dominio.Models.DTO;
using BackendTalleresHN.Transversal.Request;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BackendTalleresHN.Logica.Login
{
    public class LoginLogica : ILoginLogica
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public LoginLogica(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        public async Task<ActionResult<UserToken>> Login(LoginInfo user)
        {
            var validateUser = await ValidateUserIfExist(user);
            if (validateUser.Codigo == HttpStatusCode.Found)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, isPersistent: false, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return BuildToken(user);
                }
                else
                {
                    //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return new UserToken
                    {
                        Ok = false,
                        Message = "Contraseña Incorrecta.",
                        Codigo = HttpStatusCode.Unauthorized
                    };
                }
            }
            else
            {
                return new UserToken
                {
                    Ok = false,
                    Message = validateUser.Mensaje,
                    Codigo = validateUser.Codigo
                };
            }
        }

        private UserToken BuildToken(LoginInfo userInfo)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Tiempo de expiracion del token, En nuestro caso lo hacemos de una hora.
            var expiration = DateTime.UtcNow.AddHours(1);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: creds);

            return new UserToken()
            {
                Ok = true,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration,
                Message = "Sesion Exitosa.",
                Codigo = HttpStatusCode.Created
            };
        }

        private async Task<Request<bool>> ValidateUserIfExist(LoginInfo model)
        {
            var _request = new Request<bool>();

            var validateUsername = await _userManager.FindByNameAsync(model.UserName);

            if (validateUsername == null)
            {
                _request.Codigo = HttpStatusCode.NotFound;
                _request.Mensaje = "El usuario no existe o esta incorrecto.";
            }
            else
            {
                _request.Codigo = HttpStatusCode.Found;
            }

            return _request;
        }
    }
}
