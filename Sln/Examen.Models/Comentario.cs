using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public int IdEvento { get; set; }
        public string Contenido  { get; set; }
        public string Fecha { get; set; }
        public string Autor { get; set; }
    }
}
