using IPSSER.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IPSSER_PORTAL.Controllers
{
    public class DirectorioController : Controller
    {

        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Directorio
        public ActionResult Index()
        {
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            var tbl = db.TBL_PORTAL_DIRECTORIO_INTERNO;
            return View(tbl.ToList());
        }

        public ActionResult Admin()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            var tbl = db.TBL_PORTAL_DIRECTORIO_INTERNO;
            return View(tbl.ToList());

            return View(tbl);
        }

        // GET: Directorio/Details/5
        public ActionResult Details(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            return View();
        }

        // GET: Directorio/Create
        public ActionResult Create()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            return View();
        }

        // POST: Directorio/Create
        [HttpPost]
        public ActionResult Create(IPSSER_PORTAL.Models.TBL_PORTAL_DIRECTORIO_INTERNO modelo)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            if (ModelState.IsValid){
                db.PA_INSERT_TBL_PORTAL_DIRECTORIO_INTERNO(modelo.Departamento, modelo.Extension, modelo.Email);
                return RedirectToAction("Admin");
            }

            return View();
        }

        // GET: Directorio/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            return View();
        }

        // POST: Directorio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Directorio/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_DIRECTORIO_INTERNO tbl = db.TBL_PORTAL_DIRECTORIO_INTERNO.Find(id);
            if (tbl == null)
            {
                return HttpNotFound();
            }
            return View(tbl);
        }

        // POST: Directorio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            db.PA_DELETE_TBL_DIRECTORIO_INTERNO(id);
            return RedirectToAction("Admin");
        }
    }
}
