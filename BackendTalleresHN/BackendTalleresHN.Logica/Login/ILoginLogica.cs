using BackendTalleresHN.Dominio.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendTalleresHN.Logica.Login
{
    public interface ILoginLogica
    {
        Task<ActionResult<UserToken>> Login(LoginInfo user);
    }
}
