using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.Models
{
    public class usuario
    {
        [Key]
        public int idUsuario { get; set; }
        [Required]
        public String nombre { get; set; }
        public String apellido { get; set; }
        [Display(Name = "telefono")]
        [DataType(DataType.PhoneNumber)]
        public String telefono { get; set; }
        public String direccion { get; set; }
        [Display(Name = "clave")]
        [DataType(DataType.Password)]
        [Required]
        public String clave { get; set; }
        public String role { get; set; }
        
        [Display(Name = "Loguado")]
        public bool estado { get; set; }
    }
}
