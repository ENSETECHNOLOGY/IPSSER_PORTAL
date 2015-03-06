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
    public class ImagenesContenidoController : Controller
    {
        /*private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: ImagenesContenido
        public ActionResult Index()
        {
            //var tBL_PORTAL_CONTENIDO_IMAGENES = db.TBL_PORTAL_CONTENIDO_IMAGENES.Include(t => t.TBL_PORTAL_BIBLIOTECA_IMAGENES).Include(t => t.TBL_PORTAL_CONTENIDOFRONT);
            return View(tBL_PORTAL_CONTENIDO_IMAGENES.ToList());
        }

        // GET: ImagenesContenido/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_PORTAL_CONTENIDO_IMAGENES tBL_PORTAL_CONTENIDO_IMAGENES = db.TBL_PORTAL_CONTENIDO_IMAGENES.Find(id);
            if (tBL_PORTAL_CONTENIDO_IMAGENES == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_CONTENIDO_IMAGENES);
        }

        // GET: ImagenesContenido/Create
        public ActionResult Create()
        {
            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo");
            //ViewBag.IdContenido = new SelectList(db.TBL_PORTAL_CONTENIDOFRONT, "IdContenidoFront", "Titulo");
            return View();
        }

        // POST: ImagenesContenido/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdContenidoImagen,IdContenido,IdImagen")] TBL_PORTAL_CONTENIDO_IMAGENES tBL_PORTAL_CONTENIDO_IMAGENES)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminImagenesContenido ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminImagenesContenido();

            if (ModelState.IsValid)
            {
                Respuesta = ObjDatAdministracion.InsertarImagenContenido(tBL_PORTAL_CONTENIDO_IMAGENES.IdContenido, tBL_PORTAL_CONTENIDO_IMAGENES.IdImagen);
                return RedirectToAction("Index");
            }

            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo", tBL_PORTAL_CONTENIDO_IMAGENES.IdImagen);
            ViewBag.IdContenido = new SelectList(db.TBL_PORTAL_CONTENIDOFRONT, "IdContenidoFront", "Titulo", tBL_PORTAL_CONTENIDO_IMAGENES.IdContenido);
            return View(tBL_PORTAL_CONTENIDO_IMAGENES);
        }*/

        // GET: ImagenesContenido/Edit/5
        /*public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDO_IMAGENES tBL_PORTAL_CONTENIDO_IMAGENES = db.TBL_PORTAL_CONTENIDO_IMAGENES.Find(id);
            if (tBL_PORTAL_CONTENIDO_IMAGENES == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo", tBL_PORTAL_CONTENIDO_IMAGENES.IdImagen);
            ViewBag.IdContenido = new SelectList(db.TBL_PORTAL_CONTENIDOFRONT, "IdContenidoFront", "Titulo", tBL_PORTAL_CONTENIDO_IMAGENES.IdContenido);
            return View(tBL_PORTAL_CONTENIDO_IMAGENES);
        }*/

        // POST: ImagenesContenido/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdContenidoImagen,IdContenido,IdImagen")] TBL_PORTAL_CONTENIDO_IMAGENES tBL_PORTAL_CONTENIDO_IMAGENES)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminImagenesContenido ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminImagenesContenido();

            if (ModelState.IsValid)
            {
                Respuesta = ObjDatAdministracion.ActualizarImagenContenido(tBL_PORTAL_CONTENIDO_IMAGENES.IdContenidoImagen, tBL_PORTAL_CONTENIDO_IMAGENES.IdContenido, tBL_PORTAL_CONTENIDO_IMAGENES.IdImagen);
                return RedirectToAction("Index");
            }
            ViewBag.IdImagen = new SelectList(db.TBL_PORTAL_BIBLIOTECA_IMAGENES, "IdImagen", "Titulo", tBL_PORTAL_CONTENIDO_IMAGENES.IdImagen);
            ViewBag.IdContenido = new SelectList(db.TBL_PORTAL_CONTENIDOFRONT, "IdContenidoFront", "Titulo", tBL_PORTAL_CONTENIDO_IMAGENES.IdContenido);
            return View(tBL_PORTAL_CONTENIDO_IMAGENES);
        }*/

        // GET: ImagenesContenido/Delete/5
        /*public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDO_IMAGENES tBL_PORTAL_CONTENIDO_IMAGENES = db.TBL_PORTAL_CONTENIDO_IMAGENES.Find(id);
            if (tBL_PORTAL_CONTENIDO_IMAGENES == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_CONTENIDO_IMAGENES);
        }*/

        // POST: ImagenesContenido/Delete/5
        /*[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminImagenesContenido ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminImagenesContenido();

            TBL_PORTAL_CONTENIDO_IMAGENES tBL_PORTAL_CONTENIDO_IMAGENES = db.TBL_PORTAL_CONTENIDO_IMAGENES.Find(id);
            Respuesta = ObjDatAdministracion.EliminarImagenContenido(tBL_PORTAL_CONTENIDO_IMAGENES.IdContenidoImagen);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }*/
    }
}
