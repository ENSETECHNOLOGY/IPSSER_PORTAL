using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace IPSSER.DATOS.Administracion
{
    public class datAdminFront
    {
        private IPSSER_PORTALEntities db = new IPSSER_PORTALEntities();

        #region <<-- Metodos de Consulta -->>

        public System.Data.Entity.Core.Objects.ObjectResult<PA_SELECT_TBL_PORTAL_FRONT_Result> SeleccionarFronts()
        {
            System.Data.Entity.Core.Objects.ObjectResult<PA_SELECT_TBL_PORTAL_FRONT_Result> strResultado;
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_SELECT_TBL_PORTAL_FRONT();
            return strResultado;
        }

        #endregion

        #region <<-- Metodos de Insercion -->>
        public string InsertarFront(int IdModulo, string Titulo, string Descripcion, int IdImagen)
            {
                string strResultado = "" ;
                var Contexto = new IPSSER_PORTALEntities();
                
                strResultado = Contexto.PA_INSERT_TBL_PORTAL_FRONT(IdModulo, Titulo, Descripcion, IdImagen).ToString();
                return strResultado;
            }
        #endregion

        #region <<-- Metodos de Actualizacion -->>
            public string ActualizarFront(int IdFront, int IdModulo, string Titulo, string Descripcion, int IdImagen)
            {
            string strResultado = "";
            var Contexto = new IPSSER_PORTALEntities();

            strResultado = Contexto.PA_UPDATE_TBL_PORTAL_FRONT(IdFront, IdModulo, Titulo, Descripcion, IdImagen).ToString();

            return strResultado;
            }
        #endregion

        #region <<-- Metodos de Eliminacion -->>

            public string EliminarFront(int IdFront)
            {
                string strResultado = "";
                var Contexto = new IPSSER_PORTALEntities();

                strResultado = Contexto.PA_DELETE_TBL_PORTAL_FRONT(IdFront).ToString();

                return strResultado;
            }
        #endregion

    }
}
