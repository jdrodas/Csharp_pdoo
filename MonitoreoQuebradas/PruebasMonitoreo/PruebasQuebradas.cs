using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonitoreoQuebradas;

namespace PruebasMonitoreo
{
    [TestClass]
    public class PruebasQuebradas
    {
        /// <summary>
        /// Evalua si hay 3 quebradas en estado crítico
        /// </summary>
        [TestMethod]        
        public void EvaluaCantidadCritica()
        {
            //Arrange -- Preparar
            Quebrada[] lasQuebradas = new Quebrada[5]
            {
                new Quebrada{Nombre = "La Picacha", Caudal =96 },
                new Quebrada{Nombre = "La Presidenta", Caudal =20 },
                new Quebrada{Nombre = "La Hueso", Caudal =92 },
                new Quebrada{Nombre = "Santa Elena", Caudal =20 },
                new Quebrada{Nombre = "La Iguaná", Caudal =81 }
            };
            //Act -- Actuar
            int totalEsperado = 3;
            int totalObtenido = Program.TotalQuebradasCriticas(lasQuebradas);

            //Assert -- Valorar
            Assert.AreEqual(totalEsperado, totalObtenido);
        }

        /// <summary>
        /// Verifica que no se presenta condición de Emergencia por
        /// la cantidad de quebradas en etado critico
        /// </summary>
        [TestMethod]
        public void VerificaNoHayCondicionEmergencia()
        {
            //Arrange -- Preparar
            Quebrada[] lasQuebradas = new Quebrada[5]
            {
                new Quebrada{Nombre = "La Picacha", Caudal =96 },
                new Quebrada{Nombre = "La Presidenta", Caudal =20 },
                new Quebrada{Nombre = "La Hueso", Caudal =92 },
                new Quebrada{Nombre = "Santa Elena", Caudal =20 },
                new Quebrada{Nombre = "La Iguaná", Caudal =80 }
            };

            //Act -- Actuar
            bool condicionEsperada = false;
            bool condicionObtenida = Program.EvaluaCondicionEmergencia(lasQuebradas);

            //Assert -- Valorar
            Assert.AreEqual(condicionEsperada, condicionObtenida);
        }
    }
}