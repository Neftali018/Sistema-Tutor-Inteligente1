using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ITS.Models
{
    public class Cursos
    {
         [Key]
         public int id_temas { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]

        [StringLength(85, MinimumLength = 4, ErrorMessage = "El nombre del tema debe tener de 4 a 85 caracteres")]
        public String nombre_tema { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]

        public int id_curso { get; set; }

    }
}
