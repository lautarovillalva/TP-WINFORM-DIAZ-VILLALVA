﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DOMINIO
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string UrlImagen { get; set; }
        public double Precio { get; set; }
    }
}
