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
        [Bind(Exclude = "IdFront")]
        public class TBL_PORTAL_FRONTMetaData
        {

            //public int IdFront { get; set; }

            [Required(ErrorMessage = "Seleccione el modulo")]
            public object IdModulo { get; set; }

            [Required(ErrorMessage = "Falta El Titulo")]
            public object Titulo { get; set; }

            [Required(ErrorMessage = "Falta la Descripcion")]
            public object Descripcion { get; set; }

                     

        }


    }


}
