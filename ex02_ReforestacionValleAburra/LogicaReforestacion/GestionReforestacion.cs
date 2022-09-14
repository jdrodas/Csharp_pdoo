using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaReforestacion
{
    public class GestionReforestacion
    {
        private ActividadReforestacion[] lasActividades;
        private string[] losMunicipios;
        private int totalActividadesMunicipio;
        private int totalArbolesSobrevividos;
        private int totalActividaesExitosasComunidad;
        private int totalActividadesExitosasProveedor;
        private int TotalAguaUtilizada;

        public GestionReforestacion()
        {
            lasActividades = new ActividadReforestacion[100];
            losMunicipios = new string[]
            {
                "Barbosa",
                "Caldas",
                "Girardota",
                "Bello",
                "Medellin",
                "Copacabana",
                "La Estrella",
                "Itagüí",
                "Envigado",
                "Sabaneta"
            };


            InicializaActividades();

        }

        public void InicializaActividades()
        {
            Random aleatorio = new Random();

            for (int i = 0; i < lasActividades.Length; i++)
            {
                //Aleatoriamente seleccionamos el tipo de actividad
                //0: ActividadComunidad
                //1: ActividadProveedor
                switch (aleatorio.Next(2))
                {
                    case 0:
                        lasActividades[i] = new ActividadReforestacionComunidad()
                        {
                            CantidadArboles = aleatorio.Next(1001),
                            PorcentajeSobrevivencia = aleatorio.Next(101),
                            Municipio = losMunicipios[aleatorio.Next(losMunicipios.Length)],
                            CantidadVoluntarios = aleatorio.Next(5, 51)
                        };
                        break;

                    case 1:
                        lasActividades[i] = new ActividadReforestacionProveedor()
                        {
                            CantidadArboles = aleatorio.Next(1001),
                            PorcentajeSobrevivencia = aleatorio.Next(101),
                            Municipio = losMunicipios[aleatorio.Next(losMunicipios.Length)],
                            RecursoEspecifico = 0 //Aqui recalculamos los galones de agua
                        };

                        break;
                }
            }

        }
    }



}
