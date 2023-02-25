using LogicaFumigacion;

namespace PruebasMSTestLogicaFumigaciob
{
    [TestClass]
    public class PruebasConjuntoResidencial
    {
        [TestMethod]
        public void VerificaPorcentajeHogaresFumigadosEs100()
        {
            //Arrange
            Hogar[] hogaresPrueba =
            {
                new Hogar(),
                new Hogar(new Fumigacion("Hongos","Fungicidas")),
                new Hogar(new Fumigacion("Roedores","Neurotóxicos"))
            };

            ConjuntoResidencial urbanizacionPrueba = 
                new ConjuntoResidencial(hogaresPrueba.Length);

            urbanizacionPrueba.SetLosHogares(hogaresPrueba);

            //Act
            double porcentajeObtenido = 
                urbanizacionPrueba.ObtienePorcentajeHogaresFumigados();
            double porcentajeEsperado = 100;

            //Assert
            Assert.AreEqual(porcentajeEsperado, porcentajeObtenido);
        }

        [TestMethod]
        public void VerificaPorcentajeFumigacionNoEs60()
        {
            //Arrange
            Hogar[] hogaresPrueba =
            {
                new Hogar(new Fumigacion("Hongos","Fungicidas")),
                new Hogar(new Fumigacion("Roedores","Neurotóxicos"))
            };

            ConjuntoResidencial urbanizacionPrueba =
                new ConjuntoResidencial(hogaresPrueba.Length);

            urbanizacionPrueba.SetLosHogares(hogaresPrueba);

            //Act
            double porcentajeObtenido =
                urbanizacionPrueba.ObtienePorcentajeHogaresFumigados();
            double porcentajeEsperado = 60;

            //Assert
            Assert.AreNotEqual(porcentajeEsperado, porcentajeObtenido);
        }
    }
}
