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
        private string[] losMunicipios, losTipos;
        private int[] totalActividadesMunicipio;
        private int[] totalArbolesSobrevivientesMunicipio;
        private int[] totalActividadesTipo;
        //private int totalActividaesExitosasComunidad;
        //private int totalActividadesExitosasProveedor;
        //private int TotalAguaUtilizada;

        /// <summary>
        /// Constructor predeterminado
        /// </summary>
        public GestionReforestacion()
        {
            lasActividades = new ActividadReforestacion[100];

            totalActividadesMunicipio = new int[10];
            totalArbolesSobrevivientesMunicipio = new int[10];
            totalActividadesTipo = new int[2];

            losTipos = new string[]
            {
                "Comunidad", 
                "Proveedor" 
            };

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

        /// <summary>
        /// Constructor que recibe el arreglo de actividades
        /// </summary>
        /// <param name="lasActividades">las actividades</param>
        public GestionReforestacion(ActividadReforestacion[] lasActividades)
        {
            this.lasActividades = lasActividades;
            totalActividadesMunicipio = new int[10];

            totalArbolesSobrevivientesMunicipio = new int[10];
            totalActividadesTipo = new int[2];

            losTipos = new string[]
            {
                "Comunidad",
                "Proveedor"
            };

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
        }



        public string[] LosMunicipios
        {
            get { return losMunicipios; }
        }

        public int[] TotalActividadesMunicipio
        {
            get { return totalActividadesMunicipio; }
        }

        public int[] TotalArbolesSobrevivientesMunicipio
        {
            get { return totalArbolesSobrevivientesMunicipio; }
        }

        public void InicializaActividades()
        {
            Random aleatorio = new Random();

            for (int i = 0; i < lasActividades.Length; i++)
            {
                //Aleatoriamente seleccionamos el tipo de actividad
                //0: Tipo Comunidad
                //1: Tipo Proveedor
                switch (losTipos[aleatorio.Next(losTipos.Length)])
                {
                    case "Comunidad":
                        lasActividades[i] = new ActividadReforestacionComunidad()
                        {
                            Tipo = "Comunidad",
                            CantidadArboles = aleatorio.Next(1001),
                            PorcentajeSobrevivencia = aleatorio.Next(101),
                            Municipio = losMunicipios[aleatorio.Next(losMunicipios.Length)],
                            CantidadVoluntarios = aleatorio.Next(5, 51)
                        };
                        break;

                    case "Proveedor":
                        lasActividades[i] = new ActividadReforestacionProveedor()
                        {
                            Tipo = "Proveedor",
                            CantidadArboles = aleatorio.Next(1001),
                            PorcentajeSobrevivencia = aleatorio.Next(101),
                            Municipio = losMunicipios[aleatorio.Next(losMunicipios.Length)]
                        };
                        break;
                }
            }

        }

        /// <summary>
        /// Calcula cuantas actividades de reforestación hubo por municipio
        /// </summary>
        public void CalculaTotalActividadesMunicipio()
        {
            totalActividadesMunicipio = new int[losMunicipios.Length];

            //Inicializamos las posiciones del arreglo
            for (int i = 0; i < totalActividadesMunicipio.Length; i++)
                totalActividadesMunicipio[i] = 0;

            //Aqui recorremos el arreglo de actividades y si encontramos una coincidencia con cada municipio
            //incrementamos el contador para ese municipio
            for (int i = 0; i < losMunicipios.Length; i++)
            {
                for (int j = 0; j < lasActividades.Length; j++)
                {
                    if (lasActividades[j].Municipio == losMunicipios[i])
                        totalActividadesMunicipio[i]++;
                }
            }
        }

        public void CalculaTotalArbolesSobrevivientesMunicipio()
        {

            totalArbolesSobrevivientesMunicipio = new int[losMunicipios.Length];

            //Inicializamos las posiciones del arreglo
            for (int i = 0; i < totalArbolesSobrevivientesMunicipio.Length; i++)
                totalArbolesSobrevivientesMunicipio[i] = 0;

            //Aqui recorremos el arreglo de actividades y si encontramos una coincidencia con cada municipio
            //calculamos los arboles sobrevivientes = total Arboles * porcentaje sobrevivencia
            for (int i = 0; i < losMunicipios.Length; i++)
            {
                for (int j = 0; j < lasActividades.Length; j++)
                {
                    if (lasActividades[j].Municipio == losMunicipios[i])
                        totalArbolesSobrevivientesMunicipio[i] += 
                            (int)(lasActividades[j].CantidadArboles * lasActividades[j].PorcentajeSobrevivencia/100);
                }
            }
        }

        public void CalculaActividadesTipo()
        {
            totalActividadesTipo = new int[losTipos.Length];

            //Inicializamos las posiciones del arreglo
            for (int i = 0; i < totalActividadesTipo.Length; i++)
                totalActividadesTipo[i] = 0;

            //Aqui recorremos el arreglo de actividades y si encontramos una coincidencia con cada municipio
            //incrementamos el contador para ese municipio
            for (int i = 0; i < losTipos.Length; i++)
            {
                for (int j = 0; j < lasActividades.Length; j++)
                {
                    if (lasActividades[j].Tipo == losTipos[i])
                        totalActividadesTipo[i]++;
                }
            }

        }
    }



}
