﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackendTalleresHN.Dominio.Models.DTO
{
    public class UserEmpresaInfo
    {
        public string UserId { get; set; }
        public string NombreEmpresa { get; set; }
        public string NombreDueño { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Direccion { get; set; }
        public float Longitud { get; set; }
        public float Latitud { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool Estado { get; set; }
    }
}
