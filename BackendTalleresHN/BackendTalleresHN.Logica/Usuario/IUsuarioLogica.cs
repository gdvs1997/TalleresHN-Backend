﻿using BackendTalleresHN.Dominio.Models.DTO;
using BackendTalleresHN.Transversal.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendTalleresHN.Logica.Usuario
{
    public interface IUsuarioLogica
    {
        Task<ActionResult<UserToken>> CreateUserCliente(UserClientInfo model);
    }
}
