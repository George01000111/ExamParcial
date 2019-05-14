using Cibertec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Mvc.ViewModels
{
    public class EventosComentarioViewModel
    {
        public string EventosTitulo { get; set; }
        public List<Comentario> Comentario { get; set; }
    }
}