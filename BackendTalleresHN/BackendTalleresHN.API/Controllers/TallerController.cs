using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTalleresHN.Dominio.Models.DTO;
using BackendTalleresHN.Logica.Empresas;
using BackendTalleresHN.Logica.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTalleresHN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TallerController : ControllerBase
    {
        private readonly ITallerLogica _logica;
        public TallerController(ITallerLogica logica)
        {
            _logica = logica;
        }

        [HttpPost("Crear")]
        public async Task<ActionResult<UserToken>> CreateUserTaller([FromBody] UserTallerInfo model)
        {
            return await _logica.CreateUserTaller(model);
        }
    }
}
