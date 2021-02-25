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
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaLogica _logica;
        public EmpresaController(IEmpresaLogica logica)
        {
            _logica = logica;
        }

        [HttpPost("Crear")]
        public async Task<ActionResult<UserToken>> CreateUserEmpresa([FromBody] UserEmpresaInfo model)
        {
            return await _logica.CreateUserEmpresa(model);
        }
    }
}
