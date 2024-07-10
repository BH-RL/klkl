using NUnit.Framework;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestFixture]
    public class MaquinaDeCafeTests
    {
        [Test]
        public void SeleccionarTamanoTaza_Pequeno_Retorna3Onzas()
        {
            // Arrange
            var maquinaDeCafe = new MaquinaDeCafe();

            // Act
            var resultado = maquinaDeCafe.SeleccionarTamanoTaza(TamanoTaza.Pequeno);

            // Assert
            Assert.AreEqual(3, resultado);
        }

        [Test]
        public void SeleccionarTamanoTaza_Mediano_Retorna5Onzas()
        {
            // Arrange
            var maquinaDeCafe = new MaquinaDeCafe();

            // Act
            var resultado = maquinaDeCafe.SeleccionarTamanoTaza(TamanoTaza.Mediano);

            // Assert
            Assert.AreEqual(5, resultado);
        }

        [Test]
        public void SeleccionarTamanoTaza_Grande_Retorna7Onzas()
        {
            // Arrange
            var maquinaDeCafe = new MaquinaDeCafe();

            // Act
            var resultado = maquinaDeCafe.SeleccionarTamanoTaza(TamanoTaza.Grande);

            // Assert
            Assert.AreEqual(7, resultado);
        }

        [Test]
        public void SeleccionarCucharadasAzucar_RetornaCucharadasCorrectas()
        {
            // Arrange
            var maquinaDeCafe = new MaquinaDeCafe();

            // Act
            var resultado = maquinaDeCafe.SeleccionarCucharadasAzucar(2);

            // Assert
            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void RecogerTaza_RetornaTazaConfigurada()
        {
            // Arrange
            var maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.SeleccionarTamanoTaza(TamanoTaza.Mediano);
            maquinaDeCafe.SeleccionarCucharadasAzucar(2);

            // Act
            var taza = maquinaDeCafe.RecogerTaza();

            // Assert
            Assert.AreEqual(TamanoTaza.Mediano, taza.Tamano);
            Assert.AreEqual(2, taza.CucharadasAzucar);
            Assert.AreEqual(5, taza.OnzasDeCafe);
        }
    }
}
