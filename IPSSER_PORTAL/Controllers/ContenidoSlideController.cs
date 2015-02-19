using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IPSSER.DATOS;

namespace IPSSER_PORTAL.Controllers
{
    public class ContenidoSlideController : Controller
    {
        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: ContenidoSlide
        public ActionResult Index()
        {
            var tBL_PORTAL_CONTENIDOSLIDE = db.TBL_PORTAL_CONTENIDOSLIDE.Include(t => t.TBL_PORTAL_SLIDE);
            return View(tBL_PORTAL_CONTENIDOSLIDE.ToList());
        }

        // GET: ContenidoSlide/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDOSLIDE tBL_PORTAL_CONTENIDOSLIDE = db.TBL_PORTAL_CONTENIDOSLIDE.Find(id);
            if (tBL_PORTAL_CONTENIDOSLIDE == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_CONTENIDOSLIDE);
        }

        // GET: ContenidoSlide/Create
        public ActionResult Create()
        {
            ViewBag.IdSlide = new SelectList(db.TBL_PORTAL_SLIDE, "IdSlide", "Titulo");
            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo");
            return View();
        }

        // POST: ContenidoSlide/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdContenidoSlide,IdSlide,Titulo,Descripcion,Contenido_Uno,Contenido_Dos,Contenido_Tres, IdImagen, Link")] TBL_PORTAL_CONTENIDOSLIDE tBL_PORTAL_CONTENIDOSLIDE)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminContenidoSlide ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminContenidoSlide();

            if (ModelState.IsValid)
            {
                Respuesta = ObjDatAdministracion.InsertarContenidoSlide(tBL_PORTAL_CONTENIDOSLIDE.IdSlide, tBL_PORTAL_CONTENIDOSLIDE.Titulo, tBL_PORTAL_CONTENIDOSLIDE.Descripcion, tBL_PORTAL_CONTENIDOSLIDE.Contenido_Uno, tBL_PORTAL_CONTENIDOSLIDE.Contenido_Dos, tBL_PORTAL_CONTENIDOSLIDE.Contenido_Tres, tBL_PORTAL_CONTENIDOSLIDE.IdImagen, tBL_PORTAL_CONTENIDOSLIDE.Link);
                return RedirectToAction("Index");
            }

            ViewBag.IdSlide = new SelectList(db.TBL_PORTAL_SLIDE, "IdSlide", "Titulo", tBL_PORTAL_CONTENIDOSLIDE.IdSlide);
            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo");
            return View(tBL_PORTAL_CONTENIDOSLIDE);
        }

        // GET: ContenidoSlide/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDOSLIDE tBL_PORTAL_CONTENIDOSLIDE = db.TBL_PORTAL_CONTENIDOSLIDE.Find(id);
            if (tBL_PORTAL_CONTENIDOSLIDE == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdSlide = new SelectList(db.TBL_PORTAL_SLIDE, "IdSlide", "Titulo", tBL_PORTAL_CONTENIDOSLIDE.IdSlide);
            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo");
            return View(tBL_PORTAL_CONTENIDOSLIDE);
        }

        // POST: ContenidoSlide/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdContenidoSlide,IdSlide,Titulo,Descripcion,Contenido_Uno,Contenido_Dos,Contenido_Tres, IdImagen, Link")] TBL_PORTAL_CONTENIDOSLIDE tBL_PORTAL_CONTENIDOSLIDE)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminContenidoSlide ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminContenidoSlide();


            if (ModelState.IsValid)
            {
                Respuesta = ObjDatAdministracion.ActualizarContenidoSlide(tBL_PORTAL_CONTENIDOSLIDE.IdContenidoSlide, tBL_PORTAL_CONTENIDOSLIDE.IdSlide, tBL_PORTAL_CONTENIDOSLIDE.Titulo, tBL_PORTAL_CONTENIDOSLIDE.Descripcion, tBL_PORTAL_CONTENIDOSLIDE.Contenido_Uno, tBL_PORTAL_CONTENIDOSLIDE.Contenido_Dos, tBL_PORTAL_CONTENIDOSLIDE.Contenido_Tres, tBL_PORTAL_CONTENIDOSLIDE.IdImagen, tBL_PORTAL_CONTENIDOSLIDE.Link);
                return RedirectToAction("Index");
            }
            ViewBag.IdSlide = new SelectList(db.TBL_PORTAL_SLIDE, "IdSlide", "Titulo", tBL_PORTAL_CONTENIDOSLIDE.IdSlide);
            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo");
            return View(tBL_PORTAL_CONTENIDOSLIDE);
        }

        // GET: ContenidoSlide/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDOSLIDE tBL_PORTAL_CONTENIDOSLIDE = db.TBL_PORTAL_CONTENIDOSLIDE.Find(id);
            if (tBL_PORTAL_CONTENIDOSLIDE == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_CONTENIDOSLIDE);
        }

        // POST: ContenidoSlide/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminContenidoSlide ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminContenidoSlide();

            TBL_PORTAL_CONTENIDOSLIDE tBL_PORTAL_CONTENIDOSLIDE = db.TBL_PORTAL_CONTENIDOSLIDE.Find(id);
            Respuesta = ObjDatAdministracion.EliminarContenidoSlide(tBL_PORTAL_CONTENIDOSLIDE.IdContenidoSlide);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
