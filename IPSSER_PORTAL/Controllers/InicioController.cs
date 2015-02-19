using IPSSER.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPSSER_PORTAL.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

           
           var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
           var ListaModulos = Modulos.ToList();
           ViewBag.ListaModulos = ListaModulos;


           var FrontSlides = db.PA_SELECT_FRONTS_CON_SLIDES();
           var ListaFrontSlides = FrontSlides.ToList();
           ViewBag.ListaFrontSlides = ListaFrontSlides;


           var Front = db.PA_SELECT_FRONTS();
           var ListaFront = Front.ToList();
           ViewBag.ListaFront = ListaFront;

            return View();
        }
    }
}