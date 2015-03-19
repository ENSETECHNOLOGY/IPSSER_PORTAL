using IPSSER.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPSSER_PORTAL.Controllers
{
    public class GaleriaController : Controller
    {

        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Galeria
        public ActionResult Index()
        {
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            return View();
        }

        public ActionResult Admin()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            var tbl = db.TBL_PORTAL_GALERIA;
            return View(tbl.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Ruta, string Descripcion)
        {
            return View();
        }

    }
}