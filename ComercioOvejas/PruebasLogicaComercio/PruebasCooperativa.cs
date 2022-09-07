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

            Cooperativa CoopPrueba = new Cooperativa(ovejasPrueba, 
                                        0, 
                                        0, 
                                        0);


            // Act - Actuar
            CoopPrueba.IdentificaOvejasAptas();

            // Assert - Validar
            int totalLanudasAptasEsperadas = 2;
            int totalLanudasAptasObtenidas = CoopPrueba.TotalOvejasLanudasAptas;

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

            Cooperativa CoopPrueba = new Cooperativa(ovejasPrueba,
                            0,
                            0,
                            0);
            //Act
            CoopPrueba.IdentificaOvejasAptas();
            CoopPrueba.CalculaProduccion();

            //Assert
            int TotalLitrosLecheEsperado = 5;
            int TotalLitrosLecheObtenidos = CoopPrueba.TotalLecheProducida;

            Assert.AreEqual(TotalLitrosLecheEsperado, TotalLitrosLecheObtenidos);
        }
    }
}

/*
                new OvejaLechera() { Edad = 36, Peso = 60, Sexo = "Hembra", LitrosLeche = 5},
                new OvejaLechera() { Edad = 36, Peso = 70, Sexo = "Hembra", LitrosLeche = 1},
*/