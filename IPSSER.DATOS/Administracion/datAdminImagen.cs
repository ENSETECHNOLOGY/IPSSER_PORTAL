using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace IPSSER.DATOS.Administracion
{
    public class datAdminImagen
    {
        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        #region <<-- Metodos de Consulta -->>


        #endregion

        #region <<-- Metodos de Insercion -->>
        public string InsertarImagen(string Titulo, string Descripcion, string path)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_INSERT_TBL_PORTAL_BIBLIOTECA_IMAGENES(Titulo, Descripcion, path).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Actualizacion -->>
        public string ActualizarImagen(int IdImagen, string Titulo, string Descripcion, string path)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_UPDATE_TBL_PORTAL_BIBLIOTECA_IMAGENES(IdImagen, Titulo, Descripcion, path).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Eliminacion -->>

        public string EliminarImagen(int IdImagen)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_DELETE_TBL_PORTAL_BIBLIOTECA_IMAGENES(IdImagen).ToString();

            return strResultado;
        }
        #endregion

    }
}
