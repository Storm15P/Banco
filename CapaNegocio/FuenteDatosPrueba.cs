using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public interface FuenteDatosPrueba: FuenteDatos
    {
        public int ConsultarDatosPrueba();
    }
}
