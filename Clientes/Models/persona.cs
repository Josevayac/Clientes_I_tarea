using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clientes.Models
{
    public class persona
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required]
        public int edad { get; set; }
    }
}