﻿using System;
using System.Collections.Generic;

namespace FinalSis457Sntv.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Usuario1 { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string Rol { get; set; } = null!;
        public bool? RegistroActivo { get; set; }
    }
}
