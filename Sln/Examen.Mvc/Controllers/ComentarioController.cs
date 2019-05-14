using Cibertec.Models;
using Examen.Mvc.ViewModels;
using Examen.UnitOfWork;
using log4net;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Mvc.Controllers
{
    public class ComentarioController : BaseController
    {
        int _IdEvento;
        public ComentarioController(ILog log, IUnitOfWork unit) : base(log, unit)
        {
        }

        // GET: Comentario
        public ActionResult Index()
        {

            return View(_unit.Comentario.GetList());
        }


        public ActionResult Create(int IdEvento)
        {
            _IdEvento = IdEvento;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Comentario comentario)
        {

            int result = _unit.Comentario.Insert(comentario);
            return RedirectToAction("ComentarioByEventos", "Eventos", new { @id = comentario.IdEvento });
        }

        public ActionResult Delete(int id)
        {
            var comentario = _unit.Comentario.GetById(id);
            _unit.Comentario.Delete(comentario);
            return RedirectToAction("ComentarioByEventos", "Eventos", new { @id = comentario.IdEvento });
        }


        //public ActionResult ComentarioByEventos(int id)
        //{
        //    var eventos = _unit.Eventos.GetById(id);
        //    var comentario = _unit.Comentario.GetList();
        //    var comentarioByeventos = comentario.Where(o => o.IdEvento == id);

        //    return View(new EventosComentarioViewModel()
        //    {
        //        EventosTitulo = eventos.Titulo,
        //        Comentario = comentarioByeventos.ToList()
        //    });
        //}


    }
}