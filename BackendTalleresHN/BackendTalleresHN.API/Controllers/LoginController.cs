using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTalleresHN.Dominio.Models.DTO;
using BackendTalleresHN.Logica.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTalleresHN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginLogica _logica;

        public LoginController(ILoginLogica logica)
        {
            _logica = logica;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> LoginUser([FromBody] LoginInfo model)
        {
            return await _logica.Login(model);
        }
    }
}
