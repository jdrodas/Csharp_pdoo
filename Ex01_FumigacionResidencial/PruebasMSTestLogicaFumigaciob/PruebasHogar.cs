using LogicaFumigacion;

namespace PruebasMSTestLogicaFumigaciob
{
    [TestClass]
    public class PruebasHogar
    {
        [TestMethod]
        public void VerificaHogarNoFumigadoConValoresPredeterminados()
        {
            //Arrange
            Hogar miHogarDePrueba = new Hogar();

            //Act
            bool ValorFumigacionObtenido = miHogarDePrueba.GetEstaFumigado();
            bool ValorFumigacionEsperado = false;

            //Assert
            Assert.AreEqual(ValorFumigacionEsperado, ValorFumigacionObtenido);
        }
    }
}