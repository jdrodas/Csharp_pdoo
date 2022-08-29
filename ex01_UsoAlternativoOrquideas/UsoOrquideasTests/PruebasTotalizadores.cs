using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ex01_UsoAlternativoOrquideas;

namespace UsoOrquideasTests
{
    [TestClass]
    public class PruebasTotalizadores
    {
        [TestMethod]
        public void Test_UsoExitosoPorRegion()
        {
            //Arrange
            Orquidea[] orquideasTest = new Orquidea[12]
            {
                new Orquidea{ Origen = "Andina", MesFloracion ="Febrero", Utilizacion="Comida" },
                new Orquidea{ Origen = "Pacífica", MesFloracion ="Marzo", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Caribe", MesFloracion ="Abril", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Amazonía", MesFloracion ="Septiembre", Utilizacion="Comida y Perfume" },
                new Orquidea{ Origen = "Andina", MesFloracion ="Febrero", Utilizacion="Comida" },
                new Orquidea{ Origen = "Pacífica", MesFloracion ="Octubre", Utilizacion="Comida y Perfume" },
                new Orquidea{ Origen = "Caribe", MesFloracion ="Octubre", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Territorio Insular", MesFloracion ="Marzo", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Orinoquía", MesFloracion ="Abril", Utilizacion="Comida" },
                new Orquidea{ Origen = "Pacífica", MesFloracion ="Septiembre", Utilizacion="Comida y Perfume" },
                new Orquidea{ Origen = "Andina", MesFloracion ="Abril", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Caribe", MesFloracion ="Marzo", Utilizacion="Comida" }
            };

            string[] regionesOrigen = { "Andina", "Pacífica", "Caribe", "Orinoquía", "Amazonía", "Territorio Insular" };
            string[] posiblesUtilizaciones = { "Comida", "Perfume", "Comida y Perfume" };

            //Act
            string[] usoPreferidoPorRegion = Program.UsoExitosoPorRegion(orquideasTest, regionesOrigen, posiblesUtilizaciones);

            //Assert
            //Uso preferido para la región Andina: Comida
            string usoEsperado = "Comida";
            string usoObtenido = usoPreferidoPorRegion[0];

            Assert.AreEqual(usoEsperado, usoObtenido);
        }

        [TestMethod]
        public void Test_MesFloracionPorRegion()
        {
            //Arrange
            Orquidea[] orquideasTest = new Orquidea[12]
            {
                new Orquidea{ Origen = "Andina", MesFloracion ="Febrero", Utilizacion="Comida" },
                new Orquidea{ Origen = "Pacífica", MesFloracion ="Marzo", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Caribe", MesFloracion ="Octubre", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Amazonía", MesFloracion ="Septiembre", Utilizacion="Comida y Perfume" },
                new Orquidea{ Origen = "Andina", MesFloracion ="Febrero", Utilizacion="Comida" },
                new Orquidea{ Origen = "Pacífica", MesFloracion ="Octubre", Utilizacion="Comida y Perfume" },
                new Orquidea{ Origen = "Caribe", MesFloracion ="Octubre", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Territorio Insular", MesFloracion ="Marzo", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Orinoquía", MesFloracion ="Abril", Utilizacion="Comida" },
                new Orquidea{ Origen = "Pacífica", MesFloracion ="Septiembre", Utilizacion="Comida y Perfume" },
                new Orquidea{ Origen = "Andina", MesFloracion ="Abril", Utilizacion="Perfume" },
                new Orquidea{ Origen = "Caribe", MesFloracion ="Marzo", Utilizacion="Comida" }
            };

            string[] regionesOrigen = { "Andina", "Pacífica", "Caribe", "Orinoquía", "Amazonía", "Territorio Insular" };
            string[] mesesFloracion = { "Febrero", "Marzo", "Abril", "Septiembre", "Octubre" };

            //Act
            string[] mesFloracionExitosoPorRegion = Program.MesFloracionPorRegion(orquideasTest, regionesOrigen, mesesFloracion);

            //Assert
            //Mes floracióm Exitoso para la región Caribe: Octubre
            string usoEsperado = "Octubre";
            string usoObtenido = mesFloracionExitosoPorRegion[2];

            Assert.AreEqual(usoEsperado, usoObtenido);
        }
    }
}
