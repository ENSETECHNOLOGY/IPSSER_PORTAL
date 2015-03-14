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
    public class DocumentosController : Controller
    {

        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Documentos
        public ActionResult Index()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            var tbl = db.TBL_PORTAL_DOCUMENTO;
            return View(tbl.ToList());
        }

        // GET: Documentos/Details/5
        public ActionResult Details(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            TBL_PORTAL_DOCUMENTO tbl = db.TBL_PORTAL_DOCUMENTO.Find(id);
            if (tbl == null)
            {
                return HttpNotFound();
            }
            return View(tbl);
        }

        // GET: Documentos/Create
        public ActionResult Create()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            return View();
        }

        // POST: Documentos/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Titulo,Archivo")] IPSSER_PORTAL.Models.TBL_PORTAL_DOCUMENTO modelo)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            HttpPostedFileBase Archivo = Request.Files[0];
            
            if (ModelState.IsValid)
            {
                string nombreArchivo = Archivo.FileName;
                string path = Path.Combine(Server.MapPath("~/Documentacion"), nombreArchivo);
                Archivo.SaveAs(path);

                db.PA_INSERT_TBL_PORTAL_DOCUMENTO(modelo.Titulo, nombreArchivo);
                return Redirect("Index");
            }

            return View(modelo);
        }

        // GET: Documentos/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            TBL_PORTAL_DOCUMENTO tbl = db.TBL_PORTAL_DOCUMENTO.Find(id);
            if (tbl == null)
            {
                return HttpNotFound();
            }
            return View(tbl);
        }

        // POST: Documentos/Edit/5
        [HttpPost]
        public ActionResult Edit(int? Id, string Titulo)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            if (ModelState.IsValid)
            {
                db.PA_UPDATE_TBL_PORTAL_DOCUMENTO(Id, Titulo);
                return Redirect("../Index");
            }

            return View();
        }

        // GET: Documentos/Delete/5
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
            TBL_PORTAL_DOCUMENTO tbl = db.TBL_PORTAL_DOCUMENTO.Find(id);
            if (tbl == null)
            {
                return HttpNotFound();
            }
            return View(tbl);
        }

        // POST: Documentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            TBL_PORTAL_DOCUMENTO tbl = db.TBL_PORTAL_DOCUMENTO.Find(id);

            //Eliminar archivo
            string path = Path.Combine(Server.MapPath("~/Documentacion"), tbl.Archivo);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            db.PA_DELETE_TBL_PORTAL_DOCUMENTO(id);
            return RedirectToAction("Index");
        }
    }
}
