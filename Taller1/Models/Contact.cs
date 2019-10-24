using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        [Display(Name = "Nombre")]
        [MaxLength(length:20, ErrorMessage = "El nombre supera la longitud maxima permitida")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe ingresar un numero de telefono")]
        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d*$", ErrorMessage = "Debe ingresar un número de teléfono válido")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Debe ingresar un correo válido")]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
