using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace IPSSER.DATOS.Administracion
{
    public class datAdminContenidoSlide
    {

        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        #region <<-- Metodos de Consulta -->>


        #endregion

        #region <<-- Metodos de Insercion -->>
        public string InsertarContenidoSlide(int IdSlide, string Titulo, string Descripcion, string Contenido_Uno, string Contenido_Dos, string Contenido_Tres, int IdImagen, string Link)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_INSERT_TBL_PORTAL_CONTENIDOSLIDE(IdSlide, Titulo, Descripcion, Contenido_Uno, Contenido_Dos, Contenido_Tres, IdImagen, Link).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Actualizacion -->>
        public string ActualizarContenidoSlide(int IdContenidoSlide, int IdSlide, string Titulo, string Descripcion, string Contenido_Uno, string Contenido_Dos, string Contenido_Tres, int IdImagen, string Link)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_UPDATE_TBL_PORTAL_CONTENIDOSLIDE(IdContenidoSlide, IdSlide, Titulo, Descripcion, Contenido_Uno, Contenido_Dos, Contenido_Tres, IdImagen, Link).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Eliminacion -->>

        public string EliminarContenidoSlide(int IdContenidoSlide)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_DELETE_TBL_PORTAL_CONTENIDOSLIDE(IdContenidoSlide).ToString();

            return strResultado;
        }
        #endregion

    }
}
