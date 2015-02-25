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
    public class FrontController : Controller
    {
        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Front
        public ActionResult Index()
        {
            var tBL_PORTAL_FRONT = db.TBL_PORTAL_FRONT.Include(t => t.TBL_PORTAL_MODULO);
             return View(tBL_PORTAL_FRONT.ToList());

        }

        // GET: Front/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_FRONT tBL_PORTAL_FRONT = db.TBL_PORTAL_FRONT.Find(id);
            if (tBL_PORTAL_FRONT == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_FRONT);
        }

        // GET: Front/Create
        public ActionResult Create()
        {
            ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo");

            var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
            var ListaImagenes = Imagenes.ToList();
            ViewBag.IdImagen = ListaImagenes;

            return View();
        }

        // POST: Front/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdFront,IdModulo,Titulo,Descripcion")] IPSSER_PORTAL.Models.TBL_PORTAL_FRONT tBL_PORTAL_FRONT)
        {
            string Respuesta="";
            IPSSER.DATOS.Administracion.datAdminFront ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminFront();
            
            try
            {
                 if (Request.Form.Get("Imagen") == null)
                 {
                     ModelState.AddModelError("", "Falta Seleccionar la Imagen");
                     ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo", tBL_PORTAL_FRONT.IdModulo);

                     var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                     var ListaImagenes = Imagenes.ToList();
                     ViewBag.IdImagen = ListaImagenes;

                     return View(tBL_PORTAL_FRONT);
                 }
                string idImagen = Request.Form.Get("Imagen");
                int Id_Imagen = Convert.ToInt32(idImagen);

                if (ModelState.IsValid)
                {
                    Respuesta = ObjDatAdministracion.InsertarFront(tBL_PORTAL_FRONT.IdModulo, tBL_PORTAL_FRONT.Titulo, tBL_PORTAL_FRONT.Descripcion, Id_Imagen);

                    return RedirectToAction("Index");
                }

                ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo", tBL_PORTAL_FRONT.IdModulo);

                var Images = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImages = Images.ToList();
                ViewBag.IdImagen = ListaImages;

                return View(tBL_PORTAL_FRONT);
            }catch(DataException ex)
            {
                ModelState.AddModelError("","No se pudo Crear el front se presento un error: "+ex.Message.ToString());

                ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo", tBL_PORTAL_FRONT.IdModulo);

                var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImagenes = Imagenes.ToList();
                ViewBag.IdImagen = ListaImagenes;

                return View(tBL_PORTAL_FRONT);
            }
        }

        // GET: Front/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_FRONT tBL_PORTAL_FRONT = db.TBL_PORTAL_FRONT.Find(id);
            if (tBL_PORTAL_FRONT == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo", tBL_PORTAL_FRONT.IdModulo);

            var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
            var ListaImagenes = Imagenes.ToList();
            ViewBag.IdImagen = ListaImagenes;

            return View(tBL_PORTAL_FRONT);
        }

        // POST: Front/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFront,IdModulo,Titulo,Descripcion")] TBL_PORTAL_FRONT tBL_PORTAL_FRONT)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminFront ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminFront();

            try
            {
                if (Request.Form.Get("Imagen") == null)
                {
                    ModelState.AddModelError("", "Falta Seleccionar la Imagen");
                    ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo", tBL_PORTAL_FRONT.IdModulo);

                    var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                    var ListaImagenes = Imagenes.ToList();
                    ViewBag.IdImagen = ListaImagenes;

                    return View(tBL_PORTAL_FRONT);
                }
                string idImagen = Request.Form.Get("Imagen");
                int Id_Imagen = Convert.ToInt32(idImagen);

                if (ModelState.IsValid)
                {
                    Respuesta = ObjDatAdministracion.ActualizarFront(tBL_PORTAL_FRONT.IdFront, tBL_PORTAL_FRONT.IdModulo, tBL_PORTAL_FRONT.Titulo, tBL_PORTAL_FRONT.Descripcion, Id_Imagen);
                    return RedirectToAction("Index");
                }
                ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo", tBL_PORTAL_FRONT.IdModulo);

                var Images = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImages = Images.ToList();
                ViewBag.IdImagen = ListaImages;

                return View(tBL_PORTAL_FRONT);
            }
            catch (DataException ex)
            {
                ModelState.AddModelError("", "No se pudo Crear el front se presento un error: " + ex.Message.ToString());

                ViewBag.IdModulo = new SelectList(db.TBL_PORTAL_MODULO, "IdModulo", "NombreModulo", tBL_PORTAL_FRONT.IdModulo);

                var Imagenes = db.TBL_PORTAL_BIBLIOTECA_IMAGENES;
                var ListaImagenes = Imagenes.ToList();
                ViewBag.IdImagen = ListaImagenes;

                return View(tBL_PORTAL_FRONT);
            }
            
        }

        // GET: Front/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_FRONT tBL_PORTAL_FRONT = db.TBL_PORTAL_FRONT.Find(id);
            if (tBL_PORTAL_FRONT == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_FRONT);
        }

        // POST: Front/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminFront ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminFront();

            TBL_PORTAL_FRONT tBL_PORTAL_FRONT = db.TBL_PORTAL_FRONT.Find(id);

            Respuesta = ObjDatAdministracion.EliminarFront(tBL_PORTAL_FRONT.IdFront);

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
