using LogicaComercio;

namespace PruebasLogicaComercio
{
    [TestClass]
    public class PruebasCooperativa
    {
        [TestMethod]
        public void ValidaOvejasLanudasAptas()
        {
            // Arrange - Organizar
            Oveja[] ovejasPrueba =
            {
                new OvejaLanuda() { Edad = 32, Peso = 50, Sexo = "Macho", CantidadLana = 8},
                new OvejaLanuda() { Edad = 36, Peso = 60, Sexo = "Macho", CantidadLana = 8},
                new OvejaLanuda() { Edad = 38, Peso = 32, Sexo = "Macho", CantidadLana = 8}
            };

            Cooperativa coopPrueba = new Cooperativa(ovejasPrueba, 
                                        0, 
                                        0, 
                                        0);


            // Act - Actuar
            coopPrueba.IdentificaOvejasAptas();

            // Assert - Validar
            int totalLanudasAptasEsperadas = 2;
            int totalLanudasAptasObtenidas = coopPrueba.TotalOvejasLanudasAptas;

            Assert.AreEqual(totalLanudasAptasEsperadas, totalLanudasAptasObtenidas);
        }

        [TestMethod]
        public void ValidaCalculoProduccionLeche()
        {
            //Arrange
            Oveja[] ovejasPrueba =
            {
                new OvejaLechera() { Edad = 36, Peso = 60, Sexo = "Hembra", LitrosLeche = 5},
                new OvejaLechera() { Edad = 36, Peso = 70, Sexo = "Hembra", LitrosLeche = 1},
            };

            Cooperativa coopPrueba = new Cooperativa(ovejasPrueba,
                            0,
                            0,
                            0);
            //Act
            coopPrueba.IdentificaOvejasAptas();
            coopPrueba.CalculaProduccion();

            //Assert
            int TotalLitrosLecheEsperado = 5;
            int TotalLitrosLecheObtenidos = coopPrueba.TotalLecheProducida;

            Assert.AreEqual(TotalLitrosLecheEsperado, TotalLitrosLecheObtenidos);
        }

        [TestMethod]
        public void ValidaCalculoComisionVenta()
        {
            //Arrange
            Oveja[] ovejasPrueba =
            {
                new OvejaLechera() { Edad = 36, Peso = 60, Sexo = "Hembra", LitrosLeche = 5},
                new OvejaLechera() { Edad = 36, Peso = 70, Sexo = "Hembra", LitrosLeche = 1},
                new OvejaLanuda() { Edad = 32, Peso = 50, Sexo = "Macho", CantidadLana = 8},
                new OvejaLanuda() { Edad = 36, Peso = 60, Sexo = "Macho", CantidadLana = 8},
                new OvejaLanuda() { Edad = 38, Peso = 32, Sexo = "Macho", CantidadLana = 8}
            };

            int precioKiloLana = 950;
            int precioLitroLeche = 2300;
            float porcentajeComision = 0.05f;

            Cooperativa coopPrueba = new Cooperativa(ovejasPrueba, 
                precioLitroLeche, precioKiloLana, porcentajeComision);

            //Act
            coopPrueba.IdentificaOvejasAptas();
            coopPrueba.CalculaProduccion();
            coopPrueba.CalculaComisionVenta();

            //Assert
            float comisionEsperada = 1335f;
            float comisionObtenida = coopPrueba.TotalComisionCooperativa;
            Assert.AreEqual(comisionEsperada, comisionObtenida);
        }

        [TestMethod]
        public void ValidaPagoGranjero()
        {
            //Arrange
            Oveja[] ovejasPrueba =
            {
                new OvejaLechera() { Edad = 36, Peso = 60, Sexo = "Hembra", LitrosLeche = 5},
                new OvejaLechera() { Edad = 36, Peso = 70, Sexo = "Hembra", LitrosLeche = 1},
                new OvejaLanuda() { Edad = 32, Peso = 50, Sexo = "Macho", CantidadLana = 8},
                new OvejaLanuda() { Edad = 36, Peso = 60, Sexo = "Macho", CantidadLana = 8},
                new OvejaLanuda() { Edad = 38, Peso = 32, Sexo = "Macho", CantidadLana = 8}
            };

            int precioKiloLana = 950;
            int precioLitroLeche = 2300;
            float porcentajeComision = 0.05f;

            Cooperativa coopPrueba = new Cooperativa(ovejasPrueba,
                precioLitroLeche, precioKiloLana, porcentajeComision);

            //Act
            coopPrueba.IdentificaOvejasAptas();
            coopPrueba.CalculaProduccion();
            coopPrueba.CalculaComisionVenta();
            coopPrueba.CalculaPagoGranjero();

            //Assert
            float pagoEsperado = 18965f;
            float pagoObtenido = coopPrueba.TotalPagoGranjero;

            Assert.AreEqual(pagoEsperado, pagoObtenido);
        }
    }
}