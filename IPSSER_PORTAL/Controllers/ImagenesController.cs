using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IPSSER.DATOS;
using System.IO;

namespace IPSSER_PORTAL.Controllers
{
    public class ImagenesController : Controller
    {
        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Imagenes
        public ActionResult Index()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            return View(db.TBL_PORTAL_BIBLIOTECA_IMAGENES);
        }

        // GET: Imagenes/Details/5
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
            TBL_PORTAL_BIBLIOTECA_IMAGENES tBL_PORTAL_BIBLIOTECA_IMAGENES = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(id);
            if (tBL_PORTAL_BIBLIOTECA_IMAGENES == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_BIBLIOTECA_IMAGENES);
        }

        // GET: Imagenes/Create
        public ActionResult Create()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            return View();
        }

        // POST: Imagenes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdImagen,Titulo,Descripcion,Path")] TBL_PORTAL_BIBLIOTECA_IMAGENES tBL_PORTAL_BIBLIOTECA_IMAGENES)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminImagen ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminImagen();
            
            
            //Hacer validación de seleccion o no seleccion del archivo. De loc ontrario generar un error cuando no se seleccione.
            HttpPostedFileBase archivo = Request.Files[0];

            //


            if (ModelState.IsValid)
            {
                string nombreArchivo = Path.GetFileName(archivo.FileName);
                string path = Path.Combine(Server.MapPath("~/Imagenes"),nombreArchivo);

                archivo.SaveAs(path);
                
                Respuesta = ObjDatAdministracion.InsertarImagen(tBL_PORTAL_BIBLIOTECA_IMAGENES.Titulo, tBL_PORTAL_BIBLIOTECA_IMAGENES.Descripcion, "../Imagenes/"+nombreArchivo);
                return RedirectToAction("/Index");
            }

            return View(tBL_PORTAL_BIBLIOTECA_IMAGENES);
        }

        // GET: Imagenes/Edit/5
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
            TBL_PORTAL_BIBLIOTECA_IMAGENES tBL_PORTAL_BIBLIOTECA_IMAGENES = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(id);
            if (tBL_PORTAL_BIBLIOTECA_IMAGENES == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_BIBLIOTECA_IMAGENES);
        }

        // POST: Imagenes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdImagen,Titulo,Descripcion,Path")] TBL_PORTAL_BIBLIOTECA_IMAGENES tBL_PORTAL_BIBLIOTECA_IMAGENES)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminImagen ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminImagen();

            if (ModelState.IsValid)
            {
                Respuesta = ObjDatAdministracion.ActualizarImagen(tBL_PORTAL_BIBLIOTECA_IMAGENES.IdImagen, tBL_PORTAL_BIBLIOTECA_IMAGENES.Titulo, tBL_PORTAL_BIBLIOTECA_IMAGENES.Descripcion, tBL_PORTAL_BIBLIOTECA_IMAGENES.Path);
                return RedirectToAction("/Index");
            }
            return View(tBL_PORTAL_BIBLIOTECA_IMAGENES);
        }

        // GET: Imagenes/Delete/5
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
            TBL_PORTAL_BIBLIOTECA_IMAGENES tBL_PORTAL_BIBLIOTECA_IMAGENES = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(id);
            if (tBL_PORTAL_BIBLIOTECA_IMAGENES == null)
            {
                return HttpNotFound();
            }
            return View(tBL_PORTAL_BIBLIOTECA_IMAGENES);
        }

        // POST: Imagenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }
            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminImagen ObjDatAdministracion = new IPSSER.DATOS.Administracion.datAdminImagen();

            TBL_PORTAL_BIBLIOTECA_IMAGENES tBL_PORTAL_BIBLIOTECA_IMAGENES = db.TBL_PORTAL_BIBLIOTECA_IMAGENES.Find(id);

            Respuesta = ObjDatAdministracion.EliminarImagen(tBL_PORTAL_BIBLIOTECA_IMAGENES.IdImagen);
            return RedirectToAction("/Index");
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
