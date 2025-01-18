using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        // unit test code

        [TestMethod]
        public void validarMetodoIngreso()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // Verificación
            Assert.AreEqual(saldoEsperado, cuenta.obtenerSaldo(), 0.001, "El saldo de la cuenta no es correcto.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarIngreso_CantidadNegativa_LanzaExcepcion()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método que debe lanzar la excepción
            cuenta.realizarIngreso(-500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarReintegro_CantidadNegativa_LanzaExcepcion()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método que debe lanzar la excepción
            cuenta.realizarReintegro(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarReintegro_SaldoInsuficiente_LanzaExcepcion()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método que debe lanzar la excepción
            cuenta.realizarReintegro(2000);
        }


    }
}




