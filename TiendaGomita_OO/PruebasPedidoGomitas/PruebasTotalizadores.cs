using Microsoft.VisualStudio.TestTools.UnitTesting;
using TiendaGomita_OO;


namespace PruebasPedidoGomitas
{
    [TestClass()]
    public class PruebasTotalizadores
    {
        [TestMethod()]
        public void VerificaTotalColor()
        {
            //Arrange - Preparar
            string[] losColores = {
                "Naranjado Zapote",
                "Morado celestial",
                "Azul Pitufo",
                "Verde duende",
                "Cobre Oxidado",
                "Amarillo minion",
                "Rojo red bull",
                "Verde vive 100"};

            Gomita[] arregloGomitas = new Gomita[] {
                new Gomita{ Color = "Azul Pitufo", Forma = "", Sabor ="" },
                new Gomita{ Color = "Morado celestial", Forma = "", Sabor ="" },
                new Gomita{ Color = "Azul Pitufo", Forma = "", Sabor ="" },
                new Gomita{ Color = "Verde duende", Forma = "", Sabor ="" },
                new Gomita{ Color = "Morado celestial", Forma = "", Sabor ="" },
                new Gomita{ Color = "Azul Pitufo", Forma = "", Sabor ="" }
            };
            //Act - Actuar - Ejecutar la función que estamos probando
            //Azul Pitufo está en la posición 3
            int totalEsperado = 2;
            int totalObtenido = Program.TotalizaPorColor(arregloGomitas, losColores)[1];

            //Assert - Validar
            Assert.AreEqual(totalEsperado, totalObtenido);

        }
    }
}