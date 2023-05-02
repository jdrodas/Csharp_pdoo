using Poo_PS_GoF_ChainOfResponsibility;

namespace PruebasAprobacionPedido
{
    [TestClass]
    public class PruebasAprobacionPedidos
    {
        [TestMethod]
        public void ValidarPedidoAprobadoJuntaDirectiva()
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

            Pedido pedidoPrueba = new Pedido()
            {
                Descripcion = "Pedido de prueba muuuuy caro",
                Valor = 1000001
            };

            // Act
            LogicaAprobacionPedido pruebaLogica = new LogicaAprobacionPedido();
            pruebaLogica.InicializaJerarquiaEjecutivos(ejecutivosPrueba);
            pruebaLogica.UnPedido = pedidoPrueba;

            string resultadoAprobacionObtenido = pruebaLogica.ProcesarPedido();

            string resultadoAprobacionEsperado = "El pedido debe aprobarse en Junta Directiva";

            //Assert
            Assert.AreEqual(resultadoAprobacionEsperado, resultadoAprobacionObtenido);
        }
    }
}
