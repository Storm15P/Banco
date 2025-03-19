using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public interface FuenteDatos
    {
        public RiesgoDTO ConsultarRiesgo(string nroDoc);
        RiesgoDTO ConsultarRiesgo(int nroDoc);
    }
}
