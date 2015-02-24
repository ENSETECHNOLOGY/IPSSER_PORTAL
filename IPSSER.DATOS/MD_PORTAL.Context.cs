﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPSSER.DATOS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IPSSER_PORTALEntities : DbContext
    {
        public IPSSER_PORTALEntities()
            : base("name=IPSSER_PORTALEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_PORTAL_BIBLIOTECA_IMAGENES> TBL_PORTAL_BIBLIOTECA_IMAGENES { get; set; }
        public virtual DbSet<TBL_PORTAL_CONTENIDO_IMAGENES> TBL_PORTAL_CONTENIDO_IMAGENES { get; set; }
        public virtual DbSet<TBL_PORTAL_CONTENIDOFRONT> TBL_PORTAL_CONTENIDOFRONT { get; set; }
        public virtual DbSet<TBL_PORTAL_CONTENIDOSLIDE> TBL_PORTAL_CONTENIDOSLIDE { get; set; }
        public virtual DbSet<TBL_PORTAL_FRONT> TBL_PORTAL_FRONT { get; set; }
        public virtual DbSet<TBL_PORTAL_MODULO> TBL_PORTAL_MODULO { get; set; }
        public virtual DbSet<TBL_PORTAL_SLIDE> TBL_PORTAL_SLIDE { get; set; }
    
        public virtual int PA_DELETE_TBL_PORTAL_BIBLIOTECA_IMAGENES(Nullable<int> idImagen)
        {
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_TBL_PORTAL_BIBLIOTECA_IMAGENES", idImagenParameter);
        }
    
        public virtual int PA_DELETE_TBL_PORTAL_CONTENIDOSLIDE(Nullable<int> idContenidoSlide)
        {
            var idContenidoSlideParameter = idContenidoSlide.HasValue ?
                new ObjectParameter("IdContenidoSlide", idContenidoSlide) :
                new ObjectParameter("IdContenidoSlide", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_TBL_PORTAL_CONTENIDOSLIDE", idContenidoSlideParameter);
        }
    
        public virtual int PA_DELETE_TBL_PORTAL_FRONT(Nullable<int> idFront)
        {
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_TBL_PORTAL_FRONT", idFrontParameter);
        }
    
        public virtual int PA_DELETE_TBL_PORTAL_SLIDE(Nullable<int> idSlide)
        {
            var idSlideParameter = idSlide.HasValue ?
                new ObjectParameter("IdSlide", idSlide) :
                new ObjectParameter("IdSlide", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_TBL_PORTAL_SLIDE", idSlideParameter);
        }
    
        public virtual int PA_INSERT_TBL_PORTAL_BIBLIOTECA_IMAGENES(string titulo, string descripcion, string path)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var pathParameter = path != null ?
                new ObjectParameter("Path", path) :
                new ObjectParameter("Path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERT_TBL_PORTAL_BIBLIOTECA_IMAGENES", tituloParameter, descripcionParameter, pathParameter);
        }
    
        public virtual int PA_INSERT_TBL_PORTAL_CONTENIDOSLIDE(Nullable<int> idSlide, string titulo, string descripcion, string contenido_Uno, string contenido_Dos, string contenido_Tres, Nullable<int> idImagen, string link)
        {
            var idSlideParameter = idSlide.HasValue ?
                new ObjectParameter("IdSlide", idSlide) :
                new ObjectParameter("IdSlide", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var contenido_UnoParameter = contenido_Uno != null ?
                new ObjectParameter("Contenido_Uno", contenido_Uno) :
                new ObjectParameter("Contenido_Uno", typeof(string));
    
            var contenido_DosParameter = contenido_Dos != null ?
                new ObjectParameter("Contenido_Dos", contenido_Dos) :
                new ObjectParameter("Contenido_Dos", typeof(string));
    
            var contenido_TresParameter = contenido_Tres != null ?
                new ObjectParameter("Contenido_Tres", contenido_Tres) :
                new ObjectParameter("Contenido_Tres", typeof(string));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            var linkParameter = link != null ?
                new ObjectParameter("Link", link) :
                new ObjectParameter("Link", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERT_TBL_PORTAL_CONTENIDOSLIDE", idSlideParameter, tituloParameter, descripcionParameter, contenido_UnoParameter, contenido_DosParameter, contenido_TresParameter, idImagenParameter, linkParameter);
        }
    
        public virtual int PA_INSERT_TBL_PORTAL_FRONT(Nullable<int> idModulo, string titulo, string descripcion, Nullable<int> idImagen)
        {
            var idModuloParameter = idModulo.HasValue ?
                new ObjectParameter("IdModulo", idModulo) :
                new ObjectParameter("IdModulo", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERT_TBL_PORTAL_FRONT", idModuloParameter, tituloParameter, descripcionParameter, idImagenParameter);
        }
    
        public virtual int PA_INSERT_TBL_PORTAL_SLIDE(Nullable<int> idFront, Nullable<int> idImagen, string titulo, string descripcion)
        {
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERT_TBL_PORTAL_SLIDE", idFrontParameter, idImagenParameter, tituloParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_FRONT_Result> PA_SELECT_TBL_PORTAL_FRONT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_FRONT_Result>("PA_SELECT_TBL_PORTAL_FRONT");
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_FRONTXID_Result> PA_SELECT_TBL_PORTAL_FRONTXID(Nullable<int> idFront)
        {
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_FRONTXID_Result>("PA_SELECT_TBL_PORTAL_FRONTXID", idFrontParameter);
        }
    
        public virtual int PA_UPDATE_TBL_PORTAL_BIBLIOTECA_IMAGENES(Nullable<int> idImagen, string titulo, string descripcion, string path)
        {
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var pathParameter = path != null ?
                new ObjectParameter("Path", path) :
                new ObjectParameter("Path", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_TBL_PORTAL_BIBLIOTECA_IMAGENES", idImagenParameter, tituloParameter, descripcionParameter, pathParameter);
        }
    
        public virtual int PA_UPDATE_TBL_PORTAL_CONTENIDOSLIDE(Nullable<int> idContenidoSlide, Nullable<int> idSlide, string titulo, string descripcion, string contenido_Uno, string contenido_Dos, string contenido_Tres, Nullable<int> idImagen, string link)
        {
            var idContenidoSlideParameter = idContenidoSlide.HasValue ?
                new ObjectParameter("IdContenidoSlide", idContenidoSlide) :
                new ObjectParameter("IdContenidoSlide", typeof(int));
    
            var idSlideParameter = idSlide.HasValue ?
                new ObjectParameter("IdSlide", idSlide) :
                new ObjectParameter("IdSlide", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var contenido_UnoParameter = contenido_Uno != null ?
                new ObjectParameter("Contenido_Uno", contenido_Uno) :
                new ObjectParameter("Contenido_Uno", typeof(string));
    
            var contenido_DosParameter = contenido_Dos != null ?
                new ObjectParameter("Contenido_Dos", contenido_Dos) :
                new ObjectParameter("Contenido_Dos", typeof(string));
    
            var contenido_TresParameter = contenido_Tres != null ?
                new ObjectParameter("Contenido_Tres", contenido_Tres) :
                new ObjectParameter("Contenido_Tres", typeof(string));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            var linkParameter = link != null ?
                new ObjectParameter("Link", link) :
                new ObjectParameter("Link", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_TBL_PORTAL_CONTENIDOSLIDE", idContenidoSlideParameter, idSlideParameter, tituloParameter, descripcionParameter, contenido_UnoParameter, contenido_DosParameter, contenido_TresParameter, idImagenParameter, linkParameter);
        }
    
        public virtual int PA_UPDATE_TBL_PORTAL_FRONT(Nullable<int> idFront, Nullable<int> idModulo, string titulo, string descripcion, Nullable<int> idImagen)
        {
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            var idModuloParameter = idModulo.HasValue ?
                new ObjectParameter("IdModulo", idModulo) :
                new ObjectParameter("IdModulo", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_TBL_PORTAL_FRONT", idFrontParameter, idModuloParameter, tituloParameter, descripcionParameter, idImagenParameter);
        }
    
        public virtual int PA_UPDATE_TBL_PORTAL_SLIDE(Nullable<int> idSlide, Nullable<int> idFront, Nullable<int> idImagen, string titulo, string descripcion)
        {
            var idSlideParameter = idSlide.HasValue ?
                new ObjectParameter("IdSlide", idSlide) :
                new ObjectParameter("IdSlide", typeof(int));
    
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_TBL_PORTAL_SLIDE", idSlideParameter, idFrontParameter, idImagenParameter, tituloParameter, descripcionParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int PA_DELETE_TBL_PORTAL_FRONT_IMAGENES(Nullable<int> idFrontImagenes)
        {
            var idFrontImagenesParameter = idFrontImagenes.HasValue ?
                new ObjectParameter("IdFrontImagenes", idFrontImagenes) :
                new ObjectParameter("IdFrontImagenes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_TBL_PORTAL_FRONT_IMAGENES", idFrontImagenesParameter);
        }
    
        public virtual int PA_INSERT_TBL_PORTAL_FRONT_IMAGENES(Nullable<int> idFront, Nullable<int> idImagen)
        {
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERT_TBL_PORTAL_FRONT_IMAGENES", idFrontParameter, idImagenParameter);
        }
    
        public virtual int PA_UPDATE_TBL_PORTAL_FRONT_IMAGENES(Nullable<int> idFrontImagenes, Nullable<int> idFront, Nullable<int> idImagen)
        {
            var idFrontImagenesParameter = idFrontImagenes.HasValue ?
                new ObjectParameter("IdFrontImagenes", idFrontImagenes) :
                new ObjectParameter("IdFrontImagenes", typeof(int));
    
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_TBL_PORTAL_FRONT_IMAGENES", idFrontImagenesParameter, idFrontParameter, idImagenParameter);
        }
    
        public virtual int PA_DELETE_TBL_PORTAL_CONTENIDOFRONT(Nullable<int> idContenidoFront)
        {
            var idContenidoFrontParameter = idContenidoFront.HasValue ?
                new ObjectParameter("IdContenidoFront", idContenidoFront) :
                new ObjectParameter("IdContenidoFront", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_TBL_PORTAL_CONTENIDOFRONT", idContenidoFrontParameter);
        }
    
        public virtual int PA_INSERT_TBL_PORTAL_CONTENIDOFRONT(Nullable<int> idFront, string titulo, string descripcion, string contenido_Uno, string contenido_Dos, string contenido_Tres, Nullable<int> idImagen, string link)
        {
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var contenido_UnoParameter = contenido_Uno != null ?
                new ObjectParameter("Contenido_Uno", contenido_Uno) :
                new ObjectParameter("Contenido_Uno", typeof(string));
    
            var contenido_DosParameter = contenido_Dos != null ?
                new ObjectParameter("Contenido_Dos", contenido_Dos) :
                new ObjectParameter("Contenido_Dos", typeof(string));
    
            var contenido_TresParameter = contenido_Tres != null ?
                new ObjectParameter("Contenido_Tres", contenido_Tres) :
                new ObjectParameter("Contenido_Tres", typeof(string));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            var linkParameter = link != null ?
                new ObjectParameter("Link", link) :
                new ObjectParameter("Link", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERT_TBL_PORTAL_CONTENIDOFRONT", idFrontParameter, tituloParameter, descripcionParameter, contenido_UnoParameter, contenido_DosParameter, contenido_TresParameter, idImagenParameter, linkParameter);
        }
    
        public virtual int PA_UPDATE_TBL_PORTAL_CONTENIDOFRONT(Nullable<int> idContenidoFront, Nullable<int> idFront, string titulo, string descripcion, string contenido_Uno, string contenido_Dos, string contenido_Tres, Nullable<int> idImagen, string link)
        {
            var idContenidoFrontParameter = idContenidoFront.HasValue ?
                new ObjectParameter("IdContenidoFront", idContenidoFront) :
                new ObjectParameter("IdContenidoFront", typeof(int));
    
            var idFrontParameter = idFront.HasValue ?
                new ObjectParameter("IdFront", idFront) :
                new ObjectParameter("IdFront", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var contenido_UnoParameter = contenido_Uno != null ?
                new ObjectParameter("Contenido_Uno", contenido_Uno) :
                new ObjectParameter("Contenido_Uno", typeof(string));
    
            var contenido_DosParameter = contenido_Dos != null ?
                new ObjectParameter("Contenido_Dos", contenido_Dos) :
                new ObjectParameter("Contenido_Dos", typeof(string));
    
            var contenido_TresParameter = contenido_Tres != null ?
                new ObjectParameter("Contenido_Tres", contenido_Tres) :
                new ObjectParameter("Contenido_Tres", typeof(string));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            var linkParameter = link != null ?
                new ObjectParameter("Link", link) :
                new ObjectParameter("Link", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_TBL_PORTAL_CONTENIDOFRONT", idContenidoFrontParameter, idFrontParameter, tituloParameter, descripcionParameter, contenido_UnoParameter, contenido_DosParameter, contenido_TresParameter, idImagenParameter, linkParameter);
        }
    
        public virtual int PA_DELETE_TBL_PORTAL_CONTENIDO_IMAGENES(Nullable<int> idContenidoImagen)
        {
            var idContenidoImagenParameter = idContenidoImagen.HasValue ?
                new ObjectParameter("IdContenidoImagen", idContenidoImagen) :
                new ObjectParameter("IdContenidoImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_DELETE_TBL_PORTAL_CONTENIDO_IMAGENES", idContenidoImagenParameter);
        }
    
        public virtual int PA_INSERT_TBL_PORTAL_CONTENIDO_IMAGENES(Nullable<int> idContenido, Nullable<int> idImagen)
        {
            var idContenidoParameter = idContenido.HasValue ?
                new ObjectParameter("IdContenido", idContenido) :
                new ObjectParameter("IdContenido", typeof(int));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_INSERT_TBL_PORTAL_CONTENIDO_IMAGENES", idContenidoParameter, idImagenParameter);
        }
    
        public virtual int PA_UPDATE_TBL_PORTAL_CONTENIDO_IMAGENES(Nullable<int> idContenidoImagen, Nullable<int> idContenido, Nullable<int> idImagen)
        {
            var idContenidoImagenParameter = idContenidoImagen.HasValue ?
                new ObjectParameter("IdContenidoImagen", idContenidoImagen) :
                new ObjectParameter("IdContenidoImagen", typeof(int));
    
            var idContenidoParameter = idContenido.HasValue ?
                new ObjectParameter("IdContenido", idContenido) :
                new ObjectParameter("IdContenido", typeof(int));
    
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_UPDATE_TBL_PORTAL_CONTENIDO_IMAGENES", idContenidoImagenParameter, idContenidoParameter, idImagenParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENES_Result> PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENES_Result>("PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENES");
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENESXID_Result> PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENESXID(Nullable<int> idImagen)
        {
            var idImagenParameter = idImagen.HasValue ?
                new ObjectParameter("IdImagen", idImagen) :
                new ObjectParameter("IdImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENESXID_Result>("PA_SELECT_TBL_PORTAL_BIBLIOTECA_IMAGENESXID", idImagenParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENES_Result> PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENES_Result>("PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENES");
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENESXID_Result> PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENESXID(Nullable<int> idContenidoImagen)
        {
            var idContenidoImagenParameter = idContenidoImagen.HasValue ?
                new ObjectParameter("IdContenidoImagen", idContenidoImagen) :
                new ObjectParameter("IdContenidoImagen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENESXID_Result>("PA_SELECT_TBL_PORTAL_CONTENIDO_IMAGENESXID", idContenidoImagenParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_CONTENIDOFRONT_Result> PA_SELECT_TBL_PORTAL_CONTENIDOFRONT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_CONTENIDOFRONT_Result>("PA_SELECT_TBL_PORTAL_CONTENIDOFRONT");
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_CONTENIDOFRONTXID_Result> PA_SELECT_TBL_PORTAL_CONTENIDOFRONTXID(Nullable<int> idContenidoFront)
        {
            var idContenidoFrontParameter = idContenidoFront.HasValue ?
                new ObjectParameter("IdContenidoFront", idContenidoFront) :
                new ObjectParameter("IdContenidoFront", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_CONTENIDOFRONTXID_Result>("PA_SELECT_TBL_PORTAL_CONTENIDOFRONTXID", idContenidoFrontParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_CONTENIDOSLIDE_Result> PA_SELECT_TBL_PORTAL_CONTENIDOSLIDE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_CONTENIDOSLIDE_Result>("PA_SELECT_TBL_PORTAL_CONTENIDOSLIDE");
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_CONTENIDOSLIDEXID_Result> PA_SELECT_TBL_PORTAL_CONTENIDOSLIDEXID(Nullable<int> idContenidoSlide)
        {
            var idContenidoSlideParameter = idContenidoSlide.HasValue ?
                new ObjectParameter("IdContenidoSlide", idContenidoSlide) :
                new ObjectParameter("IdContenidoSlide", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_CONTENIDOSLIDEXID_Result>("PA_SELECT_TBL_PORTAL_CONTENIDOSLIDEXID", idContenidoSlideParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_FRONT_IMAGENES_Result> PA_SELECT_TBL_PORTAL_FRONT_IMAGENES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_FRONT_IMAGENES_Result>("PA_SELECT_TBL_PORTAL_FRONT_IMAGENES");
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_FRONT_IMAGENESXID_Result> PA_SELECT_TBL_PORTAL_FRONT_IMAGENESXID(Nullable<int> idFrontImagenes)
        {
            var idFrontImagenesParameter = idFrontImagenes.HasValue ?
                new ObjectParameter("IdFrontImagenes", idFrontImagenes) :
                new ObjectParameter("IdFrontImagenes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_FRONT_IMAGENESXID_Result>("PA_SELECT_TBL_PORTAL_FRONT_IMAGENESXID", idFrontImagenesParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_SLIDE_Result> PA_SELECT_TBL_PORTAL_SLIDE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_SLIDE_Result>("PA_SELECT_TBL_PORTAL_SLIDE");
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_SLIDEXID_Result> PA_SELECT_TBL_PORTAL_SLIDEXID(Nullable<int> idSlide)
        {
            var idSlideParameter = idSlide.HasValue ?
                new ObjectParameter("IdSlide", idSlide) :
                new ObjectParameter("IdSlide", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_SLIDEXID_Result>("PA_SELECT_TBL_PORTAL_SLIDEXID", idSlideParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_TBL_PORTAL_MODULO_Result> PA_SELECT_TBL_PORTAL_MODULO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_TBL_PORTAL_MODULO_Result>("PA_SELECT_TBL_PORTAL_MODULO");
        }
    
        public virtual ObjectResult<PA_SELECT_FRONTS_CON_SLIDES_Result> PA_SELECT_FRONTS_CON_SLIDES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_FRONTS_CON_SLIDES_Result>("PA_SELECT_FRONTS_CON_SLIDES");
        }
    
        public virtual ObjectResult<PA_SELECT_FRONTS_Result> PA_SELECT_FRONTS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_FRONTS_Result>("PA_SELECT_FRONTS");
        }
    
        public virtual ObjectResult<PA_SELECT_FRONTS_CON_SLIDESXIDMODULO_Result> PA_SELECT_FRONTS_CON_SLIDESXIDMODULO(Nullable<int> idModulo)
        {
            var idModuloParameter = idModulo.HasValue ?
                new ObjectParameter("IdModulo", idModulo) :
                new ObjectParameter("IdModulo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_FRONTS_CON_SLIDESXIDMODULO_Result>("PA_SELECT_FRONTS_CON_SLIDESXIDMODULO", idModuloParameter);
        }
    
        public virtual ObjectResult<PA_SELECT_FRONTSXIDMODULO_Result> PA_SELECT_FRONTSXIDMODULO(Nullable<int> idModulo)
        {
            var idModuloParameter = idModulo.HasValue ?
                new ObjectParameter("IdModulo", idModulo) :
                new ObjectParameter("IdModulo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_SELECT_FRONTSXIDMODULO_Result>("PA_SELECT_FRONTSXIDMODULO", idModuloParameter);
        }
    }
}
