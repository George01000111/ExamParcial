using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class Eventos
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Ingrese fecha de Inicio")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Fecha_inicio { get; set; }
        public string Autor { get; set; }
        public string Tiempo_Inicio { get; set; }
        [Display(Name = "Duracion")]
        public string Duracion_Horas { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string Id_User { get; set; }

    }
}
