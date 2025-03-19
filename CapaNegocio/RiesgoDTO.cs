using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RiesgoDTO
    {
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string Puntaje { get; set; }


        public RiesgoDTO(string tipoDoc, string nroDoc, string puntaje)
        {
            TipoDoc = tipoDoc;
            NroDoc = nroDoc;
            Puntaje = puntaje;
        }

        public RiesgoDTO()
        {
        }
    }
}
