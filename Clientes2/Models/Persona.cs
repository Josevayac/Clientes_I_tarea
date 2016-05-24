using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clientes2.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public int Telefono { get; set; }
    }
}