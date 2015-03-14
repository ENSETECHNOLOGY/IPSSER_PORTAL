using IPSSER.DATOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IPSSER_PORTAL.Controllers
{
    public class InicioController : Controller
    {

        public ActionResult Servicio(int id)
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

            // MENÚ PRINCIPAL
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            ViewBag.TituloServicio = db.TBL_PORTAL_SLIDE.Find(id).Titulo;
            ViewBag.DescripcionServicio = db.TBL_PORTAL_SLIDE.Find(id).Descripcion;
            ViewBag.Imagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(db.TBL_PORTAL_SLIDE.Find(id).IdImagen).Path;

            return View();
        }

        //GET: Nosotros
        public ActionResult Nosotros()
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

            // MENÚ PRINCIPAL
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            // ITEMS

            foreach (var registro in db.TBL_PORTAL_SLIDE)
            {
                // Nosotros

                if (registro.Titulo == "Nosotros")
                {
                    ViewBag.Nosotros = registro.Descripcion;
                    ViewBag.NosotrosImagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(registro.IdImagen).Path;
                }

                // ¿Quién Somos?

                if (registro.Titulo == "¿Quién Somos?")
                {
                    ViewBag.QuienSomos = registro.Descripcion;
                }

                // Misión

                if (registro.Titulo == "Misión")
                {
                    ViewBag.Mision = registro.Descripcion;
                }

                // Visión

                if (registro.Titulo == "Visión")
                {
                    ViewBag.Vision = registro.Descripcion;
                }

                // Valores Humanos

                if (registro.Titulo == "Valores Humanos")
                {
                    ViewBag.ValoresHumanos = registro.Descripcion.Split(';').ToList();
                }

                // Valores Corporativos

                if (registro.Titulo == "Valores Corporativos")
                {
                    ViewBag.ValoresCorporativos = registro.Descripcion.Split(';').ToList();
                }

                // Políticas de calidad

                if (registro.Titulo == "Políticas de Calidad")
                {
                    ViewBag.PoliticasCalidad = registro.Descripcion;
                }

                // Objetivos

                if (registro.Titulo == "Objetivos")
                {
                    ViewBag.Objetivos = registro.Descripcion.Split(';').ToList();
                }

                // ¿Por qué SER?

                if (registro.Titulo == "¿Por qué SER?")
                {
                    ViewBag.PorQueSER = registro.Descripcion;
                }
            }

            return View();
        }

        public ActionResult Transporte()
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

            // MENÚ PRINCIPAL
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            foreach (var registro in db.TBL_PORTAL_SLIDE)
            {                
                if (registro.Titulo == "TRANSPORTE 1")
                {
                    ViewBag.Transporte1 = registro.Descripcion;
                    ViewBag.Transporte1Imagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(registro.IdImagen).Path;
                }
                if (registro.Titulo == "TRANSPORTE 2")
                {
                    ViewBag.Transporte2 = registro.Descripcion;
                    ViewBag.Transporte2Imagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(registro.IdImagen).Path;
                }
                if (registro.Titulo == "TRANSPORTE 3")
                {
                    ViewBag.Transporte3 = registro.Descripcion;
                    ViewBag.Transporte3Imagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(registro.IdImagen).Path;
                }
                if (registro.Titulo == "TRANSPORTE 4")
                {
                    ViewBag.Transporte4 = registro.Descripcion;
                    ViewBag.Transporte4Imagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(registro.IdImagen).Path;
                }
            }

            return View();
        }

        public ActionResult QuienSomos()
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

            // MENÚ PRINCIPAL
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            foreach (var registro in db.TBL_PORTAL_SLIDE)
            {
                // ¿Quién Somos?
                if (registro.Titulo == "¿Quién Somos?")
                {
                    ViewBag.QuienSomos = registro.Descripcion;
                    return View();
                }
            }

            return View();
        }

        public ActionResult Mision()
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

            // MENÚ PRINCIPAL
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            foreach (var registro in db.TBL_PORTAL_SLIDE)
            {
                // Mision
                if (registro.Titulo == "Misión")
                {
                    ViewBag.Mision = registro.Descripcion;
                    return View();
                }
            }

            return View();
        }

        public ActionResult Vision()
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

            // MENÚ PRINCIPAL
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            foreach (var registro in db.TBL_PORTAL_SLIDE)
            {
                // Visión
                if (registro.Titulo == "Visión")
                {
                    ViewBag.Vision = registro.Descripcion;
                    return View();
                }
            }

            return View();
        }

        public ActionResult PorQueSER()
        {
            IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

            // MENÚ PRINCIPAL
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            foreach (var registro in db.TBL_PORTAL_SLIDE)
            {
                // Visión
                if (registro.Titulo == "¿Por qué SER?")
                {
                    ViewBag.PorQueSER = registro.Descripcion;
                    return View();
                }
            }

            return View();
        }

        public ActionResult Download(int? id)
        {
            IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_DOCUMENTO tbl = db.TBL_PORTAL_DOCUMENTO.Find(id);
            if (tbl == null)
            {
                return HttpNotFound();
            }

            string archivo = Path.Combine(Server.MapPath("~/Documentacion"), tbl.Archivo);

            if (!System.IO.File.Exists(archivo))
            {
                return HttpNotFound();
            }

            return File(archivo, "application/force-download", tbl.Archivo);
        }

        // GET: Inicio
        public ActionResult Index()
        {
           IPSSER.DATOS.IPSSER_PORTALEntities db = new IPSSER.DATOS.IPSSER_PORTALEntities();

           // MENÚ PRINCIPAL
           var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
           var ListaModulos = Modulos.ToList();
           ViewBag.ListaModulos = ListaModulos;
        
           /*var FrontSlides = db.PA_SELECT_FRONTS_CON_SLIDES();
           var ListaFrontSlides = FrontSlides.ToList();
           ViewBag.ListaFrontSlides = ListaFrontSlides;*/
                        
            // DOCUMENTOS

           ViewBag.Documentos = db.TBL_PORTAL_DOCUMENTO.ToList();

            // NOSOTROS

            foreach (var registro in db.TBL_PORTAL_SLIDE)
            {
                // Nosotros

                if (registro.Titulo == "Nosotros")
                {
                    ViewBag.Nosotros = registro.Descripcion;
                    ViewBag.NosotrosImagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(registro.IdImagen).Path;
                }

                // ¿Quién Somos?

                if (registro.Titulo == "¿Quién Somos?")
                {
                    ViewBag.QuienSomos = registro.Descripcion;
                }

                // Misión

                if (registro.Titulo == "Misión")
                {
                    ViewBag.Mision = registro.Descripcion;
                }

                // Visión

                if (registro.Titulo == "Visión")
                {
                    ViewBag.Vision = registro.Descripcion;
                }

                // ¿Por qué SER?

                if (registro.Titulo == "¿Por qué SER?")
                {
                    ViewBag.PorQueSER = registro.Descripcion;
                }

                // Transporte

                if (registro.Titulo == "Transporte")
                {
                    ViewBag.Transporte = registro.Descripcion;
                    ViewBag.TransporteImagen = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(registro.IdImagen).Path;
                }
            }


           var Front = db.PA_SELECT_FRONTS();
           var ListaFront = Front.ToList();
           ViewBag.ListaFront = ListaFront;
            //hasta aqui

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

            //Logo
           ViewBag.Logo = "../images/logo.png";



            return View();
        }
    }
}