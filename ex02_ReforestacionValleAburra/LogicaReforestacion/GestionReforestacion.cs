using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaReforestacion
{
    public class GestionReforestacion
    {
        //Atributos
        private string[] losMunicipios, losTiposActividades;
        private ActividadReforestacion[] lasActividades;
        private int[] totalActividadesMunicipio;
        private int[] totalArbolesSobrevivientesMunicipio;
        private int[] totalActividadesTipo;
        private int[] totalActividadesExitosasTipo;
        private float totalAguaUtilizada;

        /// <summary>
        /// Constructor predeterminado
        /// </summary>
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

            losTiposActividades = new string[]
            {
                "Comunidad",
                "Proveedor"
            };

            //Los siguientes atributos dependen de la cantidad de municipios y actividades,
            //por eso utilizamos su longitud
            totalActividadesMunicipio = new int[losMunicipios.Length];
            totalArbolesSobrevivientesMunicipio = new int[losMunicipios.Length];
            totalActividadesTipo = new int[losTiposActividades.Length];
            totalActividadesExitosasTipo = new int[losTiposActividades.Length];

            totalAguaUtilizada = 0;

            //Inicializamos las actividades
            InicializaActividades();
        }

        /// <summary>
        /// Constructor que recibe el arreglo de actividades para uso en pruebas unitarias
        /// </summary>
        /// <param name="lasActividades">las actividades</param>
        public GestionReforestacion(ActividadReforestacion[] lasActividades)
        {
            this.lasActividades = lasActividades;

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

            losTiposActividades = new string[]
            {
                "Comunidad",
                "Proveedor"
            };

            //Los siguientes atributos dependen de la cantidad de municipios y actividades,
            //por eso utilizamos su longitud
            totalActividadesMunicipio = new int[losMunicipios.Length];
            totalArbolesSobrevivientesMunicipio = new int[losMunicipios.Length];
            totalActividadesTipo = new int[losTiposActividades.Length];
            totalActividadesExitosasTipo = new int[losTiposActividades.Length];

            totalAguaUtilizada = 0;
        }

        // Propiedades

        /// <summary>
        /// Obtiene los municipios que serán reforestados
        /// </summary>
        public string[] LosMunicipios
        {
            get { return losMunicipios; }
        }

        /// <summary>
        /// Obtiene los tipos de actividades
        /// </summary>
        public string[] LosTiposActividades
        {
            get { return losTiposActividades; }
        }

        /// <summary>
        /// Obtiene el total de actividades de reforestación realizadas en el municipio
        /// </summary>
        public int[] TotalActividadesMunicipio
        {
            get { return totalActividadesMunicipio; }
        }

        /// <summary>
        /// Obtiene el total de arboles que sobrevivieron luego de la actividad de reforestación
        /// </summary>
        public int[] TotalArbolesSobrevivientesMunicipio
        {
            get { return totalArbolesSobrevivientesMunicipio; }
        }

        /// <summary>
        /// Obtiene el total de actividades de reforestación por tipo
        /// </summary>
        public int[] TotalActividadesTipo
        {
            get { return totalActividadesTipo; }
        }

        /// <summary>
        /// Obtiene el total de actividades de reforestación exitosas por tipo
        /// </summary>
        public int[] TotalActividadesExitosasTipo
        {
            get { return totalActividadesExitosasTipo; }
        }

        /// <summary>
        /// Obtiene el total de agua utilizada en las actividades de reforestación realizadas por proveedores
        /// </summary>
        public float TotalAguaUtilizada
        {
            get { return totalAguaUtilizada; }
        }


        //Los Métodos
        /// <summary>
        /// Inicializa las actividades de manera aleatoria cuando no son especificadas
        /// </summary>
        public void InicializaActividades()
        {
            Random aleatorio = new Random();

            for (int i = 0; i < lasActividades.Length; i++)
            {
                //Aleatoriamente seleccionamos el tipo de actividad del arreglo de tipos
                //Posición 0: Tipo Comunidad
                //Posición 1: Tipo Proveedor
                switch (losTiposActividades[aleatorio.Next(losTiposActividades.Length)])
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
        private void CalculaTotalActividadesMunicipio()
        {
            totalActividadesMunicipio = new int[losMunicipios.Length];

            //Inicializamos las posiciones del arreglo
            for (int i = 0; i < totalActividadesMunicipio.Length; i++)
                totalActividadesMunicipio[i] = 0;

            //Aqui recorremos el arreglo de actividades y si encontramos una
            //coincidencia con cada municipio, incrementamos el contador para
            //ese municipio
            for (int i = 0; i < losMunicipios.Length; i++)
            {
                for (int j = 0; j < lasActividades.Length; j++)
                {
                    if (lasActividades[j].Municipio == losMunicipios[i])
                        totalActividadesMunicipio[i]++;
                }
            }
        }

        /// <summary>
        /// Calcula cuantos árboles sobrevivientes en total hubo por municipio
        /// </summary>
        private void CalculaTotalArbolesSobrevivientesMunicipio()
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

        /// <summary>
        /// Calcula cuántas actividades por tipo
        /// </summary>
        private void CalculaTotalActividadesTipo()
        {
            totalActividadesTipo = new int[losTiposActividades.Length];

            //Inicializamos las posiciones del arreglo
            for (int i = 0; i < totalActividadesTipo.Length; i++)
                totalActividadesTipo[i] = 0;

            //Aqui recorremos el arreglo de actividades y si encontramos una coincidencia con cada municipio
            //incrementamos el contador para ese municipio
            for (int i = 0; i < losTiposActividades.Length; i++)
            {
                for (int j = 0; j < lasActividades.Length; j++)
                {
                    if (lasActividades[j].Tipo == losTiposActividades[i])
                        totalActividadesTipo[i]++;
                }
            }
        }

        /// <summary>
        /// Calcula el total de actividades exitosas por tipo de actividad
        /// </summary>
        private void CalculaTotalesActividadesExitosas()
        {
            for(int i=0;i< totalActividadesExitosasTipo.Length;i++)
                totalActividadesExitosasTipo[i] = 0;


            //Orden de almacenamiento en totalActividadesExitosasTipo
            //0: Comunidad
            //1: Proveedor

            foreach (ActividadReforestacion unaActividad in lasActividades)
            {
                if(unaActividad.EsExitosa)
                    switch (unaActividad.Tipo)
                    {
                        case "Comunidad":
                            totalActividadesExitosasTipo[0]++;
                            break;
                        case "Proveedor":
                            totalActividadesExitosasTipo[1]++;
                            break;
                    }
            }
        }

        /// <summary>
        /// Calcula el total de galones de agua utilizados en la actividades por proveedor
        /// </summary>
        private void CalculaTotalGalonesAgua()
        {
            totalAguaUtilizada = 0;

            //Buscamos en todas las actividades, cuales son las de proveedor
            //Que son las que utilizan el recurso de agua
            foreach (ActividadReforestacion unaActividad in lasActividades)
            {
                if (unaActividad.Tipo == "Proveedor")
                    totalAguaUtilizada += unaActividad.RecursoEspecifico;
            }
        }

        /// <summary>
        /// Ejecuta los totalizadores que corresponden a las actividades de reforestación
        /// </summary>
        public void EjecutaReforestacion()
        {
            //Aqui ejecutamos los totalizadores requeridos
            CalculaTotalActividadesMunicipio();
            CalculaTotalArbolesSobrevivientesMunicipio();
            CalculaTotalActividadesTipo();
            CalculaTotalesActividadesExitosas();
            CalculaTotalGalonesAgua();
        }
    }
}
