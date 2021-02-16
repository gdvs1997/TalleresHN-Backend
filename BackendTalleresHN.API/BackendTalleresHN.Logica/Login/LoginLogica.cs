using BackendTalleresHN.Dominio.Models;
using BackendTalleresHN.Dominio.Models.DTO;
using BackendTalleresHN.PersistenciaDatos.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendTalleresHN.Logica.Login
{
    public class LoginLogica : ILoginLogica
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IRepository _repository;

        public LoginLogica(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            IRepository repository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _repository = repository;
        }
        public Task<ActionResult<UserToken>> CreateUserClient(ClienteInfo model)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<UserToken>> Login(LoginUser user)
        {
            throw new NotImplementedException();
        }
    }
}
