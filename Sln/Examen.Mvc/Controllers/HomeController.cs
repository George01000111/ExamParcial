using Examen.Mvc.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();


            var estaAutenticado = User.Identity.IsAuthenticated;
            if (estaAutenticado)
            {
                var NombreUsuario = User.Identity.Name;
                var id = User.Identity.GetUserId();

                //using (ApplicationDbContext db = new ApplicationDbContext())
                //{

                //}
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}