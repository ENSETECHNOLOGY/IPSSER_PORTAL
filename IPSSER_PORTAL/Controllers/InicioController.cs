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


           //1	Inicio	Inicio
           //2	Servicios 1	Servicio primarios
           //3	Servicios 2	Servicios secundarios
           //4	Nosotros 1	sobre nosotros
           //5	Nosotros 2	mas sobre nosotros
           //6	Contacto	contactanos

           //Los Valores de los modulos esta quemados por el momento no se ariamos

           //Modulo Inicio
           var Inicio = db.PA_SELECT_FRONTS_CON_SLIDESXIDMODULO(1);
           var ListaInicio = Inicio.ToList();
           ViewBag.ListaInicio = ListaInicio;


           //Modulo Servicios 1
           var Servicios1 = db.PA_SELECT_FRONTS_CON_SLIDESXIDMODULO(2);
           var ListaServicios1 = Servicios1.ToList();
           ViewBag.ListaServicios1 = ListaServicios1;


           //Modulo Servicios 2
           var Servicios2 = db.PA_SELECT_FRONTS_CON_SLIDESXIDMODULO(3);
           var ListaServicios2 = Servicios2.ToList();
           ViewBag.ListaServicios2 = ListaServicios2;


           //Modulo Nosotros 1
           var Nosotros1 = db.PA_SELECT_FRONTS_CON_SLIDESXIDMODULO(4);
           var ListaNosotros1 = Nosotros1.ToList();
           ViewBag.ListaNosotros1 = ListaNosotros1;


           //Modulo Nosotros 2
           var Nosotros2 = db.PA_SELECT_FRONTS_CON_SLIDESXIDMODULO(5);
           var ListaNosotros2 = Nosotros2.ToList();
           ViewBag.ListaNosotros2 = ListaNosotros2;


           //Modulo Contacto
           var Contacto = db.PA_SELECT_FRONTS_CON_SLIDESXIDMODULO(6);
           var ListaContacto = Contacto.ToList();
           ViewBag.ListaContacto = ListaContacto;

           



            return View();
        }
    }
}