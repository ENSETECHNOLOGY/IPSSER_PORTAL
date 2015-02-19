using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace IPSSER.DATOS.Administracion
{
    public class datAdminImagenesContenido
    {
        #region <<-- Metodos de Consulta -->>


        #endregion

        #region <<-- Metodos de Insercion -->>
        public string InsertarImagenContenido(int IdContenido, int IdImagen)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_INSERT_TBL_PORTAL_CONTENIDO_IMAGENES(IdContenido, IdImagen).ToString();
            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Actualizacion -->>
        public string ActualizarImagenContenido(int IdContenidoImagen, int IdContenido, int IdImagen)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_UPDATE_TBL_PORTAL_CONTENIDO_IMAGENES(IdContenidoImagen, IdContenido, IdImagen).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Eliminacion -->>

        public string EliminarImagenContenido(int IdContenidoImagen)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_DELETE_TBL_PORTAL_CONTENIDO_IMAGENES(IdContenidoImagen).ToString();

            return strResultado;
        }
        #endregion


    }
}
