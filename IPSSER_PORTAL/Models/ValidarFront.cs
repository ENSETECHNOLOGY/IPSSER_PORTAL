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

    [MetadataType(typeof(TBL_PORTAL_USUARIOMetaData))]
    public partial class TBL_PORTAL_USUARIO
    {
        [Bind()]
        public class TBL_PORTAL_USUARIOMetaData
        {

            [Required(ErrorMessage = "Falta el Login")]
            public string Login { get; set; }

            [Required(ErrorMessage = "Falta la Clave")]
            public string Clave { get; set; }

        }

    }

    [MetadataType(typeof(TBL_PORTAL_DOCUMENTOMetaData))]
    public partial class TBL_PORTAL_DOCUMENTO
    {
        [Bind()]
        public class TBL_PORTAL_DOCUMENTOMetaData
        {

            [Required(ErrorMessage = "Falta el Título")]
            public string Titulo { get; set; }

            public string Archivo { get; set; }

        }

    }

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

    [MetadataType(typeof(TBL_PORTAL_TRABAJA_CON_NOSOTROSMetaData))]
    public partial class TBL_PORTAL_TRABAJA_CON_NOSOTROS
    {
        [Bind()]
        public class TBL_PORTAL_TRABAJA_CON_NOSOTROSMetaData
        {
            [Required(ErrorMessage = "Debes escribir tus Nombres")]
            public string Nombres { get; set; }

            [Required(ErrorMessage = "Debes escribir tus Apellidos")]
            public string Apellidos { get; set; }

            [Required(ErrorMessage = "Debes escribir tu Teléfono Fijo")]
            public string TelefonoFijo { get; set; }

            [Required(ErrorMessage = "Debes escribir tu Celular")]
            public string Celular { get; set; }

            [Required(ErrorMessage = "Debes adjuntar tu Hoja de Vida")]
            public string ArchivoHojaDeVida { get; set; }
        }
    }

    [MetadataType(typeof(TBL_PORTAL_DIRECTORIO_INTERNOMetaData))]
    public partial class TBL_PORTAL_DIRECTORIO_INTERNO
    {
        [Bind()]
        public class TBL_PORTAL_DIRECTORIO_INTERNOMetaData
        {
            [Required(ErrorMessage = "Debe escribir el Departamento")]
            public string Departamento { get; set; }

            [Required(ErrorMessage = "Debe escribir la Extensión")]
            public string Extension { get; set; }

            [Required(ErrorMessage = "Debe escribir el Email")]
            public string Email { get; set; }
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

