using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace IPSSER.DATOS.Administracion
{
    public class datAdminImagenesFront
    {

        #region <<-- Metodos de Consulta -->>


        #endregion

        #region <<-- Metodos de Insercion -->>
        public string InsertarImagenFront(int IdFront, int IdImagen)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_INSERT_TBL_PORTAL_FRONT_IMAGENES(IdFront, IdImagen).ToString();
            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Actualizacion -->>
        public string ActualizarImagenFront(int IdFrontImagenes, int IdFront, int IdImagen)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_UPDATE_TBL_PORTAL_FRONT_IMAGENES(IdFrontImagenes, IdFront, IdImagen).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Eliminacion -->>

        public string EliminarImagenFront(int IdFrontImagenes)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_DELETE_TBL_PORTAL_FRONT_IMAGENES(IdFrontImagenes).ToString();

            return strResultado;
        }
        #endregion

    }
}
