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
    public class SlideController : Controller
    {
        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Slide
        public ActionResult Index()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            var tBL_PORTAL_SLIDE = db.TBL_PORTAL_SLIDE.Include(t => t.TBL_PORTAL_BIBLIOTECA_IMAGENES).Include(t => t.TBL_PORTAL_FRONT);
            return View(tBL_PORTAL_SLIDE.ToList());
        }

        // GET: Slide/Details/5
        public ActionResult Details(int? id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_SLIDE tBL_PORTAL_SLIDE = db.TBL_PORTAL_SLIDE.Find(id);
            if (tBL_PORTAL_SLIDE == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_SLIDE);
        }

        // GET: Slide/Create
        public ActionResult Create()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
            var ListaImagenes = Imagenes.ToList();
            ViewBag.IdImagen = ListaImagenes;
            
            ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo");
            return View();
        }

        // POST: Slide/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSlide,IdFront,IdImagen,Titulo,Descripcion,Contenido_Uno,Contenido_Dos,Contenido_Tres,Link")] TBL_PORTAL_SLIDE tBL_PORTAL_SLIDE)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminSlide ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminSlide();

            try
            {

                if (Request.Form.Get("Imagen") == null)
                {
                    ModelState.AddModelError("", "Falta Seleccionar la Imagen");

                    var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                    var ListaImagenes = Imagenes.ToList();
                    ViewBag.IdImagen = ListaImagenes;

                    ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_SLIDE.IdFront);

                    return View(tBL_PORTAL_SLIDE);
                }
                string idImagen = Request.Form.Get("Imagen");
                int Id_Imagen = Convert.ToInt32(idImagen);

                if (ModelState.IsValid)
                {
                    Respuesta = ObjDatAdministracion.InsertarSlide(tBL_PORTAL_SLIDE.IdFront, Id_Imagen, tBL_PORTAL_SLIDE.Titulo, tBL_PORTAL_SLIDE.Descripcion, tBL_PORTAL_SLIDE.Contenido_Uno, tBL_PORTAL_SLIDE.Contenido_Dos, tBL_PORTAL_SLIDE.Contenido_Tres, tBL_PORTAL_SLIDE.Link);
                    return RedirectToAction("Index");
                }

                var Images = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImages = Images.ToList();
                ViewBag.IdImagen = ListaImages;

                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_SLIDE.IdFront);
                return View(tBL_PORTAL_SLIDE);
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", "No se pudo Crear el slide se presento un error: " + ex.Message.ToString());

               
                var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImagenes = Imagenes.ToList();
                ViewBag.IdImagen = ListaImagenes;

                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_SLIDE.IdFront);

                return View(tBL_PORTAL_SLIDE);
            }
        }

        // GET: Slide/Edit/5
        public ActionResult Edit(int? id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_SLIDE tBL_PORTAL_SLIDE = db.TBL_PORTAL_SLIDE.Find(id);
            if (tBL_PORTAL_SLIDE == null)
            {
                return HttpNotFound();
            }

            var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
            var ListaImagenes = Imagenes.ToList();
            ViewBag.IdImagen = ListaImagenes;

            ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_SLIDE.IdFront);
            return View(tBL_PORTAL_SLIDE);
        }

        // POST: Slide/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSlide,IdFront,IdImagen,Titulo,Descripcion,Contenido_Uno,Contenido_Dos,Contenido_Tres,Link")] TBL_PORTAL_SLIDE tBL_PORTAL_SLIDE)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminSlide ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminSlide();

            try
            {

                if (Request.Form.Get("Imagen") == null)
                {
                    ModelState.AddModelError("", "Falta Seleccionar la Imagen");

                    var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                    var ListaImagenes = Imagenes.ToList();
                    ViewBag.IdImagen = ListaImagenes;

                    ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_SLIDE.IdFront);

                    return View(tBL_PORTAL_SLIDE);
                }
                string idImagen = Request.Form.Get("Imagen");
                int Id_Imagen = Convert.ToInt32(idImagen);

                if (ModelState.IsValid)
                {
                    Respuesta = ObjDatAdministracion.ActualizarSlide(tBL_PORTAL_SLIDE.IdSlide, tBL_PORTAL_SLIDE.IdFront, Id_Imagen, tBL_PORTAL_SLIDE.Titulo, tBL_PORTAL_SLIDE.Descripcion, tBL_PORTAL_SLIDE.Contenido_Uno, tBL_PORTAL_SLIDE.Contenido_Dos, tBL_PORTAL_SLIDE.Contenido_Tres, tBL_PORTAL_SLIDE.Link);
                    return RedirectToAction("Index");
                }

                var Images = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImages = Images.ToList();
                ViewBag.IdImagen = ListaImages;

                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_SLIDE.IdFront);
                return View(tBL_PORTAL_SLIDE);
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", "No se pudo Editar el slide se presento un error: " + ex.Message.ToString());

               
                var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImagenes = Imagenes.ToList();
                ViewBag.IdImagen = ListaImagenes;

                ViewBag.IdFront = new SelectList(db.TBL_PORTAL_FRONT, "IdFront", "Titulo", tBL_PORTAL_SLIDE.IdFront);

                return View(tBL_PORTAL_SLIDE);
            }
        }
        

        // GET: Slide/Delete/5
        public ActionResult Delete(int? id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_SLIDE tBL_PORTAL_SLIDE = db.TBL_PORTAL_SLIDE.Find(id);
            if (tBL_PORTAL_SLIDE == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_SLIDE);
        }

        // POST: Slide/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminSlide ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminSlide();

            TBL_PORTAL_SLIDE tBL_PORTAL_SLIDE = db.TBL_PORTAL_SLIDE.Find(id);
            Respuesta = ObjDatAdministracion.EliminarSlide(tBL_PORTAL_SLIDE.IdSlide);
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
