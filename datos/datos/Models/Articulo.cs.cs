﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace datos.Models
{
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set;  }
    }
}