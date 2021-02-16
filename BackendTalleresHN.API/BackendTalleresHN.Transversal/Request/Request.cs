﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BackendTalleresHN.Transversal.Request
{
    public class Request<T>
    {
        public T Entity { get; set; }
        public String Mensaje { get; set; }
        public HttpStatusCode Codigo { get; set; }
        public String Exception { get; set; }
    }
}
