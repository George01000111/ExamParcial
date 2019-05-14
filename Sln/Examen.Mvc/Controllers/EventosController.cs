using Examen.Models;
using Examen.Mvc.ViewModels;
using Examen.Repositories.Dapper.BD;
using Examen.UnitOfWork;
using log4net;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Mvc.Controllers
{
 
    public class EventosController : BaseController
    {

      

        public EventosController(ILog log, IUnitOfWork unit) : base(log, unit)
        {
        }

        // GET: Customer
        public ActionResult Index()
        {
            var estaAutenticado = User.Identity.IsAuthenticated;

            if (estaAutenticado)
            {
                var NombreUsuario = User.Identity.Name;
                var id = User.Identity.GetUserId();

                if  (NombreUsuario == "admin@events.com")
                {
                    return View(_unit.Eventos.GetList());
                }
                else{
                    return View(_unit.Eventos.GetList().Where(q => q.Id_User == id));
                }
                
            }
            else
            {

                return View(_unit.Eventos.GetList());

            }

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Eventos eventos)
        {

            var estaAutenticado = User.Identity.IsAuthenticated;
            if (estaAutenticado)
            {
                var id = User.Identity.GetUserId();
                eventos.Id_User = id;
            }
 
            int result = _unit.Eventos.Insert(eventos);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var customer = _unit.Eventos.GetById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Eventos eventos)
        {

            bool result = _unit.Eventos.Update(eventos);
            return RedirectToAction("Index");
        }


        public ActionResult Details(int id)
        {
            return View(_unit.Eventos.GetById(id));
        }



        public ActionResult Delete(int id)
        {
            var eventos = _unit.Eventos.GetById(id);
            _unit.Eventos.Delete(eventos);
            return RedirectToAction("Index");
        }

        //[LoggingFilter]
        //public ActionResult DetailsName(string clientName)
        //{
        //    var customer = _unit.Eventos.GetList()
        //        .Where(q => q.Id == clientName).FirstOrDefault();

        //    var customer2 = _unit.Eventos.GetList()
        //        .FirstOrDefault(q => q.FirstName == clientName);

        //    return View("Details", customer);
        //}


        public ActionResult ComentarioByEventos(int id)
        {
            var eventos = _unit.Eventos.GetById(id);
            var comentario = _unit.Comentario.GetList();
            var comentarioByeventos = comentario.Where(o => o.IdEvento == id);

            return View(new EventosComentarioViewModel()
            {
                EventosTitulo = eventos.Id.ToString(),
                Comentario = comentarioByeventos.ToList()
            });
        }



    }
}