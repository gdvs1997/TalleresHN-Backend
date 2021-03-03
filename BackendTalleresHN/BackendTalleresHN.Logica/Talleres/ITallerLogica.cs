using BackendTalleresHN.Dominio.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendTalleresHN.Logica.Empresas
{
    public interface ITallerLogica
    {
        Task<ActionResult<UserToken>> CreateUserTaller(UserTallerInfo model);
    }
}
