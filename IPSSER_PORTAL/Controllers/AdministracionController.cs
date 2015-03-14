using IPSSER.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPSSER_PORTAL.Controllers
{
    public class AdministracionController : Controller
    {

        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Administracion
        public ActionResult Index()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("Login");
            }

            return View();
        }

        //GET
        public ActionResult Login()
        {
            if (Session["LOGUEADO"] != null && (bool)Session["LOGUEADO"] == true)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Login(string Login, string Clave)
        {
            if (db.PA_INICIAR_SESION(Login, Clave).Count() == 0) {
                ViewBag.Respuesta = "Acceso no autorizado";
                return View();
            }
            else {
                Session["LOGUEADO"] = true;
                Redirect("Index");
                return RedirectToAction("Index");
            }
        }

        //GET
        public ActionResult Logout()
        {
            Session["LOGUEADO"] = null;
            return RedirectToAction("Login");
        }
    }
}