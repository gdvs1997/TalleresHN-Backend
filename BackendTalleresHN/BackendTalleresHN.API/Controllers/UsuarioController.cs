using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTalleresHN.Dominio.Models.DTO;
using BackendTalleresHN.Logica.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTalleresHN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioLogica _logica;

        public UsuarioController(IUsuarioLogica logica)
        {
            _logica = logica;
        }

        [HttpPost("Crear")]
        public async Task<ActionResult<UserToken>> CreateUserClient([FromBody] UserClientInfo model)
        {
            return await _logica.CreateUserCliente(model);
        }
    }
}
