using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ITS.Models
{
    public class Curso
    {
        [Key]
        public int id_curso { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]

        [StringLength(85, MinimumLength =4, ErrorMessage = "El nombre debe tener de 4 a 85 carateres")]
        public String nombre_curso { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]

        [StringLength(85, MinimumLength =4, ErrorMessage = "El nivel debe tener de 4 a 85 caracteres")]
        public String nivel { get; set; }
        
    }

}
