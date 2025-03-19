// DatosPruebas/MockFuenteDatos.cs
using CapaNegocio;

namespace DatosPruebas
{
    public class MockFuenteDatos : FuenteDatos
    {
        private readonly int _puntajeFijo;

        public MockFuenteDatos(int puntajeFijo = 0)
        {
            _puntajeFijo = puntajeFijo;
        }

        public RiesgoDTO ConsultarRiesgo(string nroDoc) => new RiesgoDTO { Puntaje = _puntajeFijo.ToString() };

        public RiesgoDTO ConsultarRiesgo(int nroDoc) => new RiesgoDTO { Puntaje = _puntajeFijo.ToString() };
    }
}