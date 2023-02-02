using TiendaDeZapatos_POO;

namespace PruebasZapatos
{
    [TestClass]
    public class PruebasModas
    {
        [TestMethod]
        public void PruebaEstiloModaEsTenis()
        {
            //Arrange - Preparar los datos con los que se realizarán las pruebas
            string[] estilosPrueba = { "Tenis", "Botas", "Sandalia Gladiadora"};
            Zapato[] zapatosPrueba = {
                new Zapato(){ Estilo = "Tenis", Color = "Azul", Talla = 30},
                new Zapato(){ Estilo = "Botas", Color = "Verde", Talla = 32},
                new Zapato(){ Estilo = "Tenis", Color = "Azul", Talla = 34},
                new Zapato(){ Estilo = "Botas", Color = "Blanco", Talla = 30},
                new Zapato(){ Estilo = "Sandalia Gladiadora", Color = "Azul", Talla = 38},
                new Zapato(){ Estilo = "Tenis", Color = "Blanco", Talla = 40}
            };

            Tienda tiendaPrueba = new Tienda();

            //Act - Ejecuta el método que se quiere probar

            ZapatoModa ZapatoObtenido = tiendaPrueba.CalculaEstiloMayor(zapatosPrueba,
                                            estilosPrueba);

            string estiloEsperadoPrueba = "Tenis";

            //Assert - Compara los valores esperados con los obtenidos
            Assert.AreEqual(estiloEsperadoPrueba, ZapatoObtenido.GetEstilo());
        }

        [TestMethod]
        public void PruebaEstiloModaTenisEsTres()
        {
            //Arrange - Preparar los datos con los que se realizarán las pruebas
            string[] estilosPrueba = { "Tenis", "Botas", "Sandalia Gladiadora" };
            Zapato[] zapatosPrueba = {
                new Zapato(){ Estilo = "Tenis", Color = "Azul", Talla = 30},
                new Zapato(){ Estilo = "Botas", Color = "Verde", Talla = 32},
                new Zapato(){ Estilo = "Tenis", Color = "Azul", Talla = 34},
                new Zapato(){ Estilo = "Botas", Color = "Blanco", Talla = 30},
                new Zapato(){ Estilo = "Sandalia Gladiadora", Color = "Azul", Talla = 38},
                new Zapato(){ Estilo = "Tenis", Color = "Blanco", Talla = 40}
            };

            Tienda tiendaPrueba = new Tienda();

            //Act - Ejecuta el método que se quiere probar

            ZapatoModa ZapatoObtenido = tiendaPrueba.CalculaEstiloMayor(zapatosPrueba,
                                            estilosPrueba);

            int cantidadEsperadaPrueba = 3;

            //Assert - Compara los valores esperados con los obtenidos
            Assert.AreEqual(cantidadEsperadaPrueba, ZapatoObtenido.GetCantidad());
        }

        [TestMethod]
        public void PruebaEstiloModaTenisNoEsDos()
        {
            //Arrange - Preparar los datos con los que se realizarán las pruebas
            string[] estilosPrueba = { "Tenis", "Botas", "Sandalia Gladiadora" };
            Zapato[] zapatosPrueba = {
                new Zapato(){ Estilo = "Tenis", Color = "Azul", Talla = 30},
                new Zapato(){ Estilo = "Botas", Color = "Verde", Talla = 32},
                new Zapato(){ Estilo = "Tenis", Color = "Azul", Talla = 34},
                new Zapato(){ Estilo = "Botas", Color = "Blanco", Talla = 30},
                new Zapato(){ Estilo = "Sandalia Gladiadora", Color = "Azul", Talla = 38},
                new Zapato(){ Estilo = "Tenis", Color = "Blanco", Talla = 40}
            };

            Tienda tiendaPrueba = new Tienda();

            //Act - Ejecuta el método que se quiere probar

            ZapatoModa ZapatoObtenido = tiendaPrueba.CalculaEstiloMayor(zapatosPrueba,
                                            estilosPrueba);

            int cantidadEsperadaPrueba = 2;

            //Assert - Compara los valores esperados con los obtenidos
            Assert.AreNotEqual(cantidadEsperadaPrueba, ZapatoObtenido.GetCantidad());
        }
    }
}