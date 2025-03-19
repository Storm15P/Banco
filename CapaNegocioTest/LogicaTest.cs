using CapaNegocio;
using DatosPruebas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasCredito
    {
        private LogicaBanco _logica;

        
        [TestMethod]
        public void Caso1_RazonAlta_CreditoNegado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos());
            var resultado = _logica.EvaluarCredito(
                monto: 18000M,
                plazo: 12,
                ingresos: 2000M,
                egresos: 500M,
                nroDoc: 1
            );
            Assert.IsTrue(resultado.Contains("Denegado"));
        }

        
        [TestMethod]
        public void Caso2_Puntaje800_Aprobado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos(800));
            var resultado = _logica.EvaluarCredito(
                monto: 50400M,
                plazo: 24,
                ingresos: 5000M,
                egresos: 2000M,
                nroDoc: 2
            );
            Assert.AreEqual("Aprobado", resultado);
        }

        [TestMethod]
        public void Caso2_Puntaje700_Negado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos(700));
            var resultado = _logica.EvaluarCredito(
                monto: 50400M,
                plazo: 24,
                ingresos: 5000M,
                egresos: 2000M,
                nroDoc: 2
            );
            Assert.IsTrue(resultado.Contains("insuficiente"));
        }

        
        [TestMethod]
        public void Caso3_Puntaje600_Aprobado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos(600));
            var resultado = _logica.EvaluarCredito(
                monto: 97200M,
                plazo: 36,
                ingresos: 6000M,
                egresos: 1500M,
                nroDoc: 3
            );
            Assert.AreEqual("Aprobado", resultado);
        }

        [TestMethod]
        public void Caso3_Puntaje500_Negado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos(500));
            var resultado = _logica.EvaluarCredito(
                monto: 97200M,
                plazo: 36,
                ingresos: 6000M,
                egresos: 1500M,
                nroDoc: 3
            );
            Assert.IsTrue(resultado.Contains("insuficiente"));
        }

        
        [TestMethod]
        public void Caso4_Puntaje400_Aprobado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos(400));
            var resultado = _logica.EvaluarCredito(
                monto: 95040M,
                plazo: 48,
                ingresos: 8000M,
                egresos: 2000M,
                nroDoc: 4
            );
            Assert.AreEqual("Aprobado", resultado);
        }

        [TestMethod]
        public void Caso4_Puntaje300_Negado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos(300));
            var resultado = _logica.EvaluarCredito(
                monto: 95040M,
                plazo: 48,
                ingresos: 8000M,
                egresos: 2000M,
                nroDoc: 4
            );
            Assert.IsTrue(resultado.Contains("insuficiente"));
        }

        
        [TestMethod]
        public void Caso5_BalanzaCero_Negado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos());
            var resultado = _logica.EvaluarCredito(
                monto: 10000M,
                plazo: 12,
                ingresos: 1500M,
                egresos: 1500M,
                nroDoc: 5
            );
            Assert.IsTrue(resultado.Contains("Balanza negativa"));
        }

        [TestMethod]
        public void Caso5_BalanzaNegativa_Negado()
        {
            _logica = new LogicaBanco(new MockFuenteDatos());
            var resultado = _logica.EvaluarCredito(
                monto: 10000M,
                plazo: 12,
                ingresos: 1000M,
                egresos: 1200M,
                nroDoc: 5
            );
            Assert.IsTrue(resultado.Contains("Balanza negativa"));
        }
    }
}