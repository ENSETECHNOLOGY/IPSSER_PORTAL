using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;



namespace IPSSER_PORTAL.Models
{
    [MetadataType(typeof(TBL_PORTAL_FRONTMetaData))]
    public partial class TBL_PORTAL_FRONT
    {
        [Bind()]
        public class TBL_PORTAL_FRONTMetaData
        {

            public int IdFront { get; set; }

            [Required(ErrorMessage = "Seleccione el modulo")]
            public object IdModulo { get; set; }

            [Required(ErrorMessage = "Falta El Titulo")]
            public object Titulo { get; set; }

            [Required(ErrorMessage = "Falta la Descripcion")]
            public object Descripcion { get; set; }

            [Required(ErrorMessage = "Seleccione la Imagen")]
            public int IdImagen { get; set; }
        }
        
    }

    [MetadataType(typeof(TBL_PORTAL_SLIDEMetaData))]
    public partial class TBL_PORTAL_SLIDE
    {
        [Bind()]
        public class TBL_PORTAL_SLIDEMetaData
        {

            public object IdSlide { get; set; }

            [Required(ErrorMessage = "Seleccione el Front")]
            public object IdFront { get; set; }

             [Required(ErrorMessage = "Seleccione la Imagen")]
            public object IdImagen { get; set; }

             [Required(ErrorMessage = "Falta el Titulo")]
            public object Titulo { get; set; }

             [Required(ErrorMessage = "Falta la Descripcion")]
            public object Descripcion { get; set; }

        }

    }


    [MetadataType(typeof(TBL_PORTAL_CONTENIDOFRONTMetaData))]
    public partial class TBL_PORTAL_CONTENIDOFRONT
    {
        [Bind()]
        public class TBL_PORTAL_CONTENIDOFRONTMetaData
        {

            public object IdContenidoFront { get; set; }

            [Required(ErrorMessage = "Seleccione el Front")]
            public object IdFront { get; set; }

            [Required(ErrorMessage = "Falta el Titulo")]
            public object Titulo { get; set; }

            [Required(ErrorMessage = "Falta la Descripcion")]
            public object Descripcion { get; set; }

            [Required(ErrorMessage = "Falta el Contenido Uno")]
            public object Contenido_Uno { get; set; }

            [Required(ErrorMessage = "Falta el Contenido Dos")]
            public object Contenido_Dos { get; set; }

            [Required(ErrorMessage = "Falta el Contenido Tres")]
            public object Contenido_Tres { get; set; }

            [Required(ErrorMessage = "Seleccione la imagen")]
            public object IdImagen { get; set; }

            [Required(ErrorMessage = "Falta el Link")]
            public object Link { get; set; }

        }

    }


    [MetadataType(typeof(TBL_PORTAL_CONTENIDOSLIDEMetaData))]
    public partial class TBL_PORTAL_CONTENIDOSLIDE
    {
        [Bind()]
        public class TBL_PORTAL_CONTENIDOSLIDEMetaData
        {

            public object IdContenidoSlide { get; set; }

            [Required(ErrorMessage = "Seleccione el Front")]
            public object IdSlide { get; set; }

            [Required(ErrorMessage = "Falta el Titulo")]
            public object Titulo { get; set; }

            [Required(ErrorMessage = "Falta la Descripcion")]
            public object Descripcion { get; set; }

            [Required(ErrorMessage = "Falta el Contenido Uno")]
            public object Contenido_Uno { get; set; }

            [Required(ErrorMessage = "Falta el Contenido Dos")]
            public object Contenido_Dos { get; set; }

            [Required(ErrorMessage = "Falta el Contenido Tres")]
            public object Contenido_Tres { get; set; }

            [Required(ErrorMessage = "Seleccione la imagen")]
            public object IdImagen { get; set; }

            [Required(ErrorMessage = "Falta el Link")]
            public object Link { get; set; }

        }

    }


    [MetadataType(typeof(TBL_PORTAL_CONTENIDO_IMAGENESMetaData))]
    public partial class TBL_PORTAL_CONTENIDO_IMAGENES
    {
        [Bind()]
        public class TBL_PORTAL_CONTENIDO_IMAGENESMetaData
        {

            public object IdContenidoImagen { get; set; }

            [Required(ErrorMessage = "Seleccione el contenido")]
            public object IdContenido { get; set; }

            [Required(ErrorMessage = "Seleccione La Imagen")]
            public object IdImagen { get; set; }

        }

    }


    [MetadataType(typeof(TBL_PORTAL_BIBLIOTECA_IMAGENESMetaData))]
    public partial class TBL_PORTAL_BIBLIOTECA_IMAGENES
    {
        [Bind()]
        public class TBL_PORTAL_BIBLIOTECA_IMAGENESMetaData
        {

            public int IdImagen { get; set; }

            [Required(ErrorMessage = "Falta el Titulo")]
            public string Titulo { get; set; }

            [Required(ErrorMessage = "Falta la descripcion")]
            public string Descripcion { get; set; }

            [Required(ErrorMessage = "Seleccione La Imagen")]
            public string Path { get; set; }

        }

    }

}

