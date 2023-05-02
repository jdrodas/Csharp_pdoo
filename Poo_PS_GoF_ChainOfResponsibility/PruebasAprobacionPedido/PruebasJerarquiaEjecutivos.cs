using Poo_PS_GoF_ChainOfResponsibility;

namespace PruebasAprobacionPedido
{
    [TestClass]
    public class PruebasJerarquiaEjecutivos
    {
        [TestMethod]
        public void ValidarJerarquiaCorrecta()
        {
            // Arrange
            Ejecutivo[] ejecutivosPrueba = new Ejecutivo[3];
            ejecutivosPrueba[0] = new Director();
            ejecutivosPrueba[1] = new Gerente();
            ejecutivosPrueba[2] = new Presidente();

            ejecutivosPrueba[0].Nombre = "Un tal Clemente";
            ejecutivosPrueba[0].Monto = 250000;
            ejecutivosPrueba[0].Jefe = ejecutivosPrueba[1];

            ejecutivosPrueba[1].Nombre = "Un tal Clemente";
            ejecutivosPrueba[1].Monto = 600000;
            ejecutivosPrueba[1].Jefe = ejecutivosPrueba[2];

            ejecutivosPrueba[2].Nombre = "Posiblemente Vicente";
            ejecutivosPrueba[2].Monto = 1000000;
            ejecutivosPrueba[2].Jefe = null;

            // Act
            LogicaAprobacionPedido pruebaLogica = new LogicaAprobacionPedido();
            pruebaLogica.InicializaJerarquiaEjecutivos(ejecutivosPrueba);

            string mensajeValidacion = string.Empty;
            string motivoError = string.Empty;
            bool resultadoValidacionObtenido = pruebaLogica.EvaluaJerarquia(out mensajeValidacion, out motivoError);

            // Assert
            Assert.IsTrue(resultadoValidacionObtenido);
        }

        [TestMethod]
        public void ValidarFalloJerarquiaPorMontos()
        {
            // Arrange
            Ejecutivo[] ejecutivosPrueba = new Ejecutivo[3];
            ejecutivosPrueba[0] = new Director();
            ejecutivosPrueba[1] = new Gerente();
            ejecutivosPrueba[2] = new Presidente();

            ejecutivosPrueba[0].Nombre = "Un tal Clemente";
            ejecutivosPrueba[0].Monto = 250000;
            ejecutivosPrueba[0].Jefe = ejecutivosPrueba[1];

            ejecutivosPrueba[1].Nombre = "Un tal Clemente";
            ejecutivosPrueba[1].Monto = 6000;
            ejecutivosPrueba[1].Jefe = ejecutivosPrueba[2];

            ejecutivosPrueba[2].Nombre = "Posiblemente Vicente";
            ejecutivosPrueba[2].Monto = 1000000;
            ejecutivosPrueba[2].Jefe = null;

            // Act
            LogicaAprobacionPedido pruebaLogica = new LogicaAprobacionPedido();
            pruebaLogica.InicializaJerarquiaEjecutivos(ejecutivosPrueba);

            string mensajeValidacion = string.Empty;
            string motivoErrorObtenido = string.Empty;
            bool resultadoValidacionObtenido = pruebaLogica.EvaluaJerarquia(out mensajeValidacion, out motivoErrorObtenido);

            //Assert
            string motivoErrorEsperado = "montos sin jerarquia";

            Assert.AreEqual(motivoErrorEsperado, motivoErrorObtenido);

        }

        [TestMethod]
        public void ValidarFalloJerarquiaPorEjecutivosHuerfanos()
        {
            // Arrange
            Ejecutivo[] ejecutivosPrueba = new Ejecutivo[3];
            ejecutivosPrueba[0] = new Director();
            ejecutivosPrueba[1] = new Gerente();
            ejecutivosPrueba[2] = new Presidente();

            ejecutivosPrueba[0].Nombre = "Un tal Clemente";
            ejecutivosPrueba[0].Monto = 250000;
            ejecutivosPrueba[0].Jefe = null;

            ejecutivosPrueba[1].Nombre = "Un tal Clemente";
            ejecutivosPrueba[1].Monto = 600000;
            ejecutivosPrueba[1].Jefe = ejecutivosPrueba[2];

            ejecutivosPrueba[2].Nombre = "Posiblemente Vicente";
            ejecutivosPrueba[2].Monto = 1000000;
            ejecutivosPrueba[2].Jefe = null;

            // Act
            LogicaAprobacionPedido pruebaLogica = new LogicaAprobacionPedido();
            pruebaLogica.InicializaJerarquiaEjecutivos(ejecutivosPrueba);

            string mensajeValidacion = string.Empty;
            string motivoErrorObtenido = string.Empty;
            bool resultadoValidacionObtenido = pruebaLogica.EvaluaJerarquia(out mensajeValidacion, out motivoErrorObtenido);

            //Assert
            string motivoErrorEsperado = "ejecutivos sin jefe";

            Assert.AreEqual(motivoErrorEsperado, motivoErrorObtenido);
        }
    }
}