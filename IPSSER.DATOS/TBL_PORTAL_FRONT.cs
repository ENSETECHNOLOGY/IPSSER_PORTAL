//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TBL_PORTAL_FRONT
    {
        public TBL_PORTAL_FRONT()
        {
            this.TBL_PORTAL_CONTENIDOFRONT = new HashSet<TBL_PORTAL_CONTENIDOFRONT>();
            this.TBL_PORTAL_SLIDE = new HashSet<TBL_PORTAL_SLIDE>();
        }
    
        public int IdFront { get; set; }
        public int IdModulo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdImagen { get; set; }
    
        public virtual ICollection<TBL_PORTAL_CONTENIDOFRONT> TBL_PORTAL_CONTENIDOFRONT { get; set; }
        public virtual TBL_PORTAL_MODULO TBL_PORTAL_MODULO { get; set; }
        public virtual ICollection<TBL_PORTAL_SLIDE> TBL_PORTAL_SLIDE { get; set; }
        public virtual TBL_PORTAL_BIBLIOTECA_IMAGENES TBL_PORTAL_BIBLIOTECA_IMAGENES { get; set; }
    }
}
