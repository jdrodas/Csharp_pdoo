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
                new Hogar(new Fumigacion("Insectos","Desinfectantes")),
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

        [TestMethod]
        public void VerificaProductoPlagaMasUtilizadoEsHongosFungicidas()
        {
            //Arrange - Preparar
            FumigacionDisponible[] fumigacionesPrueba =
            {
                new FumigacionDisponible("Hongos","Fungicidas",10),
                new FumigacionDisponible("Roedores","Neurotóxicos",2),
                new FumigacionDisponible("Hongos","Inhibidores",5),
                new FumigacionDisponible("Insectos","Repelentes",17),
                new FumigacionDisponible("Roedores","Anticoagulantes",3)
            };

            ConjuntoResidencial urbanizacionPrueba = new ConjuntoResidencial(fumigacionesPrueba.Length);

            //Act - Actuar
            List<FumigacionDisponible> pruebaFumigacionesExitosas =
                urbanizacionPrueba.ObtieneProductoPlagaMasUtilizado(fumigacionesPrueba);

            //Assert - Verificar
            string valorEsperado = "Insectos - Repelentes";
            string valorObtenido = $"{pruebaFumigacionesExitosas.FirstOrDefault()!.GetPlaga()} - " +
                $"{pruebaFumigacionesExitosas.FirstOrDefault()!.GetMetodoFumigacion()}";

            Assert.AreEqual(valorEsperado,valorObtenido);
        }
    }
}
