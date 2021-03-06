﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BackendTalleresHN.Dominio.Models.DTO
{
    public class UserToken
    {
        public Boolean Ok { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public HttpStatusCode Codigo { get; set; }
        public string Message { get; set; }
    }
}
