using System;
using System.Collections.Generic;
using System.Text;

namespace BackendTalleresHN.Dominio.Models.DTO
{
    public class UserClientInfo
    {
        public string IdUser { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
