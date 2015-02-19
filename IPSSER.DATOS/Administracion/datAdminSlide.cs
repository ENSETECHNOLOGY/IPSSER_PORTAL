using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace IPSSER.DATOS.Administracion
{
    public class datAdminSlide
    {

        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        #region <<-- Metodos de Consulta -->>


        #endregion

        #region <<-- Metodos de Insercion -->>
        public string InsertarSlide(int IdFront, int IdImagen,string Titulo, string Descripcion)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_INSERT_TBL_PORTAL_SLIDE(IdFront, IdImagen, Titulo, Descripcion).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Actualizacion -->>
        public string ActualizarSlide(int IdSlide, int IdFront, int IdImagen, string Titulo, string Descripcion)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_UPDATE_TBL_PORTAL_SLIDE(IdSlide, IdFront, IdImagen, Titulo, Descripcion).ToString();

            return strResultado;
        }
        #endregion

        #region <<-- Metodos de Eliminacion -->>

        public string EliminarSlide(int IdSlide)
        {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_DELETE_TBL_PORTAL_SLIDE(IdSlide).ToString();

            return strResultado;
        }
        #endregion

    }
}
