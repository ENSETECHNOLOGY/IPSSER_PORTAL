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
    public class TrabajaController : Controller
    {

        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        // GET: Trabaja
        public ActionResult Index()
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            var tBL_PORTAL_TRABAJA_CON_NOSOTROS = db.TBL_PORTAL_TRABAJA_CON_NOSOTROS;
            return View(tBL_PORTAL_TRABAJA_CON_NOSOTROS.ToList());
        }

        // GET: Trabaja/Details/5
        public ActionResult Details(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_TRABAJA_CON_NOSOTROS tBL = db.TBL_PORTAL_TRABAJA_CON_NOSOTROS.Find(id);
            if (tBL == null)
            {
                return HttpNotFound();
            }
            return View(tBL);
        }

        // GET: Trabaja/Create
        public ActionResult Create()
        {

            //Listas de prueba
            //desq¿de aqui 
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            return View();
        }

        public ActionResult Download(int? id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_PORTAL_TRABAJA_CON_NOSOTROS tBL_PORTAL_TRABAJA_CON_NOSOTROS = db.TBL_PORTAL_TRABAJA_CON_NOSOTROS.Find(id);
            if (tBL_PORTAL_TRABAJA_CON_NOSOTROS == null)
            {
                return HttpNotFound();
            }

            string archivo = Path.Combine(Server.MapPath("~/HojasVida"), tBL_PORTAL_TRABAJA_CON_NOSOTROS.ArchivoHojaDeVida);
            return File(archivo, "application/force-download", "Hoja_De_Vida_" + tBL_PORTAL_TRABAJA_CON_NOSOTROS.Nombres + "_" + tBL_PORTAL_TRABAJA_CON_NOSOTROS.Apellidos + ".pdf");
        }

        // POST: Trabaja/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombres,Apellidos,TelefonoFijo,Celular,ArchivoHojaDeVida")] IPSSER_PORTAL.Models.TBL_PORTAL_TRABAJA_CON_NOSOTROS modelo)
        {
            var Modulos = db.PA_SELECT_TBL_PORTAL_MODULO();
            var ListaModulos = Modulos.ToList();
            ViewBag.ListaModulos = ListaModulos;

            HttpPostedFileBase hojaDeVida = Request.Files[0];

            if (hojaDeVida.ContentType != "application/pdf")
            {
                ModelState.AddModelError("ArchivoHojaDeVida", "Solo se admiten documentos PDF");
            }

            if (ModelState.IsValid)
            {
                string nombreAleatorio = Path.GetRandomFileName().ToString();
                nombreAleatorio = nombreAleatorio.Replace(".", "");
                nombreAleatorio += ".pdf";
                string path = Path.Combine(Server.MapPath("~/HojasVida"), nombreAleatorio);
                hojaDeVida.SaveAs(path);

                IPSSER.DATOS.Administracion.datAdminTrabaja ObjDatTrabajo = new IPSSER.DATOS.Administracion.datAdminTrabaja();
                ObjDatTrabajo.InsertarTrabaja(modelo.Nombres, modelo.Apellidos, modelo.TelefonoFijo, modelo.Celular, nombreAleatorio);

                return Redirect("Create?res=ok");
            }

            return View(modelo);
        }

        // GET: Trabaja/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            return View();
        }

        // POST: Trabaja/Edit/5
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

        // GET: Trabaja/Delete/5
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
            TBL_PORTAL_TRABAJA_CON_NOSOTROS tbl = db.TBL_PORTAL_TRABAJA_CON_NOSOTROS.Find(id);
            if (tbl == null)
            {
                return HttpNotFound();
            }
            return View(tbl);
        }

        // POST: Trabaja/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (Session["LOGUEADO"] == null)
            {
                return RedirectToAction("../Administracion/Login");
            }

            string Respuesta = "";
            IPSSER.DATOS.Administracion.datAdminTrabaja ObjData = new IPSSER.DATOS.Administracion.datAdminTrabaja();
            TBL_PORTAL_TRABAJA_CON_NOSOTROS tbl = db.TBL_PORTAL_TRABAJA_CON_NOSOTROS.Find(id);

            //Eliminar hoja de vida
            string path = Path.Combine(Server.MapPath("~/HojasVida"), tbl.ArchivoHojaDeVida);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            Respuesta = ObjData.EliminarTrabaja((int)tbl.IdTrabajaConNosotros);
            return RedirectToAction("Index");
        }
    }
}
