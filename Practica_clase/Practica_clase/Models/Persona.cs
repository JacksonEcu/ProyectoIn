using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Practica_clase.Models
{
    public class Persona

    {

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required(ErrorMessage =@"EL ""Apellido""es obligatorio:" )]
        [DisplayName("El Apellido")]
        public string Apellido { get; set; }
        public Celular   Celular{ get; set; }
    }

}
