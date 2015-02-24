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
    public class ContenidoFrontController : Controller
    {
        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: ContenidoFront
        public ActionResult Index()
        {
            var tBL_PORTAL_CONTENIDOFRONT = db.TBL_PORTAL_CONTENIDOFRONT.Include(t => t.TBL_PORTAL_FRONT);
            return View(tBL_PORTAL_CONTENIDOFRONT.ToList());
        }

        // GET: ContenidoFront/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDOFRONT tBL_PORTAL_CONTENIDOFRONT = db.TBL_PORTAL_CONTENIDOFRONT.Find(id);
            if (tBL_PORTAL_CONTENIDOFRONT == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_CONTENIDOFRONT);
        }

        // GET: ContenidoFront/Create
        public ActionResult Create()
        {
            ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo");

            var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
            var ListaImagenes = Imagenes.ToList();
            ViewBag.IdImagen = ListaImagenes;

            return View();
        }

        // POST: ContenidoFront/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdContenidoFront,IdFront,Titulo,Descripcion,Contenido_Uno,Contenido_Dos,Contenido_Tres, IdImagen, Link")] TBL_PORTAL_CONTENIDOFRONT tBL_PORTAL_CONTENIDOFRONT)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminContenidoFront ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminContenidoFront();

            try
            {
                if (Request.Form.Get("Imagen") == null)
                {
                    ModelState.AddModelError("", "Falta Seleccionar la Imagen");
                    ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_CONTENIDOFRONT.IdFront);

                    var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                    var ListaImagenes = Imagenes.ToList();
                    ViewBag.IdImagen = ListaImagenes;

                    return View(tBL_PORTAL_CONTENIDOFRONT);
                }
                string idImagen = Request.Form.Get("Imagen");
                int Id_Imagen = Convert.ToInt32(idImagen);

                if (ModelState.IsValid)
                {
                    Respuesta = ObjDatAdministracion.InsertarContenidoFront(tBL_PORTAL_CONTENIDOFRONT.IdFront, tBL_PORTAL_CONTENIDOFRONT.Titulo, tBL_PORTAL_CONTENIDOFRONT.Descripcion, tBL_PORTAL_CONTENIDOFRONT.Contenido_Uno, tBL_PORTAL_CONTENIDOFRONT.Contenido_Dos, tBL_PORTAL_CONTENIDOFRONT.Contenido_Tres, Id_Imagen, tBL_PORTAL_CONTENIDOFRONT.Link);
                    return RedirectToAction("Index");
                }

                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_CONTENIDOFRONT.IdFront);

                var Images = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImages = Images.ToList();
                ViewBag.IdImagen = ListaImages;

                return View(tBL_PORTAL_CONTENIDOFRONT);
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", "No se pudo Crear el Contenido front se presento un error: " + ex.Message.ToString());

                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_CONTENIDOFRONT.IdFront);

                var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImagenes = Imagenes.ToList();
                ViewBag.IdImagen = ListaImagenes;

                return View(tBL_PORTAL_CONTENIDOFRONT);
            }
        }

        // GET: ContenidoFront/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDOFRONT tBL_PORTAL_CONTENIDOFRONT = db.TBL_PORTAL_CONTENIDOFRONT.Find(id);
            if (tBL_PORTAL_CONTENIDOFRONT == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_CONTENIDOFRONT.IdFront);

            var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
            var ListaImagenes = Imagenes.ToList();
            ViewBag.IdImagen = ListaImagenes;

            return View(tBL_PORTAL_CONTENIDOFRONT);
        }

        // POST: ContenidoFront/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdContenidoFront,IdFront,Titulo,Descripcion,Contenido_Uno,Contenido_Dos,Contenido_Tres, IdImagen, Link")] TBL_PORTAL_CONTENIDOFRONT tBL_PORTAL_CONTENIDOFRONT)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminContenidoFront ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminContenidoFront();

            try
            {
                if (Request.Form.Get("Imagen") == null)
                {
                    ModelState.AddModelError("", "Falta Seleccionar la Imagen");
                    ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_CONTENIDOFRONT.IdFront);

                    var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                    var ListaImagenes = Imagenes.ToList();
                    ViewBag.IdImagen = ListaImagenes;

                    return View(tBL_PORTAL_CONTENIDOFRONT);
                }
                string idImagen = Request.Form.Get("Imagen");
                int Id_Imagen = Convert.ToInt32(idImagen);

                if (ModelState.IsValid)
                {
                    Respuesta = ObjDatAdministracion.ActualizarContenidoFront(tBL_PORTAL_CONTENIDOFRONT.IdContenidoFront, tBL_PORTAL_CONTENIDOFRONT.IdFront, tBL_PORTAL_CONTENIDOFRONT.Titulo, tBL_PORTAL_CONTENIDOFRONT.Descripcion, tBL_PORTAL_CONTENIDOFRONT.Contenido_Uno, tBL_PORTAL_CONTENIDOFRONT.Contenido_Dos, tBL_PORTAL_CONTENIDOFRONT.Contenido_Tres, Id_Imagen, tBL_PORTAL_CONTENIDOFRONT.Link);
                    return RedirectToAction("Index");
                }
                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_CONTENIDOFRONT.IdFront);

                var Images = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImages = Images.ToList();
                ViewBag.IdImagen = ListaImages;

                return View(tBL_PORTAL_CONTENIDOFRONT);
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", "No se pudo Crear el Contenido front se presento un error: " + ex.Message.ToString());

                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_CONTENIDOFRONT.IdFront);

                var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImagenes = Imagenes.ToList();
                ViewBag.IdImagen = ListaImagenes;

                return View(tBL_PORTAL_CONTENIDOFRONT);
            }
        }

        // GET: ContenidoFront/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_CONTENIDOFRONT tBL_PORTAL_CONTENIDOFRONT = db.TBL_PORTAL_CONTENIDOFRONT.Find(id);
            if (tBL_PORTAL_CONTENIDOFRONT == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_CONTENIDOFRONT);
        }

        // POST: ContenidoFront/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminContenidoFront ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminContenidoFront();

            TBL_PORTAL_CONTENIDOFRONT tBL_PORTAL_CONTENIDOFRONT = db.TBL_PORTAL_CONTENIDOFRONT.Find(id);
            Respuesta = ObjDatAdministracion.ActualizarContenidoFront(tBL_PORTAL_CONTENIDOFRONT.IdContenidoFront, tBL_PORTAL_CONTENIDOFRONT.IdFront, tBL_PORTAL_CONTENIDOFRONT.Titulo, tBL_PORTAL_CONTENIDOFRONT.Descripcion, tBL_PORTAL_CONTENIDOFRONT.Contenido_Uno, tBL_PORTAL_CONTENIDOFRONT.Contenido_Dos, tBL_PORTAL_CONTENIDOFRONT.Contenido_Tres, tBL_PORTAL_CONTENIDOFRONT.IdImagen, tBL_PORTAL_CONTENIDOFRONT.Link);
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
