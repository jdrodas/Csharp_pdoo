using Microsoft.VisualStudio.TestTools.UnitTesting;
using FabricadorArepas;
using System;

namespace PruebasFabricador
{
    [TestClass]
    public class PruebasTotalizadores
    {
        [TestMethod]
        public void TotalesPorMasaCorrecto()
        {
            //Arrange - Preparar
            string[] tiposMasa = { "Chocolo", "Yuca", "Maiz", "Quinua", "Arroz" };
            Arepa[] arepasPrueba = new Arepa[5];

            arepasPrueba[0] = new ArepaCongelada() { TipoDeMasa = "Arroz"};
            arepasPrueba[1] = new ArepaProcesada() { TipoDeMasa = "Yuca" }; 
            arepasPrueba[2] = new ArepaAsada() { TipoDeMasa = "Quinua" }; 
            arepasPrueba[3] = new ArepaProcesada() { TipoDeMasa = "Yuca" };
            arepasPrueba[4] = new ArepaAsada() { TipoDeMasa = "Maiz" };

            //Act - Actuar
            int totalEsperadoArepasYuca = 2;
            int totalObtenidoArepasYuca = Program.TotalesPorMasa(arepasPrueba, tiposMasa)[1];

            //Assert - Validar
            Assert.AreEqual(totalEsperadoArepasYuca, totalObtenidoArepasYuca);
        }
    }
}
