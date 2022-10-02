using System;
using System.Collections.Generic;

namespace PryEntity.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public DateOnly FechaNacimiento { get; set; }
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
