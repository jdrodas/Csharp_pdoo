using System;
using System.Linq;
using System.Text;

namespace ex02_EmprendimientosDigitales
{
    class GestionPrograma
    {
        //Atributos de la clase
        private Empresa[] lasEmpresas;
        private string[] losTipos, losMunicipios;

        //El constructor de la clase
        public GestionPrograma()
        {
            lasEmpresas = new Empresa[1000];

            losTipos = new string[] { "Videojuegos",
                                    "Libros Interactivos",
                                    "Podcasts"};

            losMunicipios = new string[] {
                "Medellín",
                "Barbosa",
                "Girardota",
                "Copacabana",
                "Bello",
                "Itagüí",
                "Sabaneta",
                "Envigado",
                "La Estrella",
                "Caldas"};

            //Inicializamos el arreglo según las reglas definidas
            InicializaSimulacion();
        }

        public void InicializaSimulacion()
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            int datoTipo, datoMunicipio;

            //aqui inicializamos el arreglo de manera aleatoria
            for (int i = 0; i < lasEmpresas.Length; i++)
            {
                datoTipo = aleatorio.Next(losTipos.Length);
                datoMunicipio = aleatorio.Next(losMunicipios.Length);

                //dependiendo del torneo asignado, se inicializa con el constructor de la clase
                //de ese tipo de jugador
                switch (datoTipo)
                {
                    case 0: //Videojuegos
                        lasEmpresas[i] = new EmpresaVideoJuegos(losMunicipios[datoMunicipio],
                                                                losTipos[datoTipo],
                                                                aleatorio.Next(1, 21),
                                                                aleatorio.Next(1, 16));
                        break;

                    case 1: //Libros Interactivos
                        lasEmpresas[i] = new EmpresaLibros(losMunicipios[datoMunicipio],
                                                                losTipos[datoTipo],
                                                                aleatorio.Next(1, 13),
                                                                aleatorio.Next(1, 9));
                        break;

                    case 2: //Podcasts
                        lasEmpresas[i] = new EmpresaPodcasts(losMunicipios[datoMunicipio],
                                                                losTipos[datoTipo],
                                                                aleatorio.Next(1, 71),
                                                                aleatorio.Next(1, 49));
                        break;
                }

                lasEmpresas[i].EvaluaElegibilidad();
            }
        }

        public string InformacionPrograma()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("Resultados de la ejecución:" + Environment.NewLine + Environment.NewLine);
            resultado.Append("Total empresas elegibles por sector productivo:" + Environment.NewLine + Environment.NewLine);
            resultado.Append(ObtieneTotalElegiblesSector() + Environment.NewLine);

            resultado.Append(Environment.NewLine + "Total juegos publicados por empresas en cada municipio:" + Environment.NewLine + Environment.NewLine);
            resultado.Append(ObtieneTotalJuegosPublicadosMunicipio() + Environment.NewLine);

            resultado.Append(Environment.NewLine + "Porcentaje empresas NO elegibles por municipio:" + Environment.NewLine + Environment.NewLine);
            resultado.Append(ObtienePorcentajeNoElegiblesMunicipio());

            return resultado.ToString();
        }

        private string ObtieneTotalElegiblesSector()
        {

            //un arreglo que se encarga de totalizar los elegibles por cada sector
            int[] contadorElegiblesSector = new int[losTipos.Length];

            //inicializamos todos los contadores en 0
            for (int i = 0; i < contadorElegiblesSector.Length; i++)
                contadorElegiblesSector[i] = 0;

            //recorremos el arreglo de las empresas preguntando por su sector y si son elegibles
            for (int i = 0; i < lasEmpresas.Length; i++)
                for (int j = 0; j < losTipos.Length; j++)
                    if (losTipos[j] == lasEmpresas[i].TipoRecurso && lasEmpresas[i].EsElegible)
                        contadorElegiblesSector[j]++;

            //Finalmente, creamos el string con la información solicitada
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < losTipos.Length; i++)
            {
                resultado.Append("Sector: " + losTipos[i] +
                    ", empresas: " + contadorElegiblesSector[i].ToString() +
                    Environment.NewLine);
            }

            return resultado.ToString();
        }

        private string ObtieneTotalJuegosPublicadosMunicipio()
        {

            //Declaramos una empresa de VideoJuegos
            EmpresaVideoJuegos empresaTemporal;

            //un arreglo que se encarga de totalizar los elegibles por cada sector
            int[] TotalJuegosPublicadosMunicipio = new int[losMunicipios.Length];

            //inicializamos todos los contadores en 0
            for (int i = 0; i < TotalJuegosPublicadosMunicipio.Length; i++)
                TotalJuegosPublicadosMunicipio[i] = 0;

            //recorremos el arreglo de empresas preguntando si es de videojuegos  y si tiene juegos publicados
            for (int i = 0; i < lasEmpresas.Length; i++)
                for (int j = 0; j < losMunicipios.Length; j++)
                    if (losMunicipios[j] == lasEmpresas[i].Municipio && lasEmpresas[i].TipoRecurso== "Videojuegos")
                    {
                        //Si la empresa es de videojuegos, convertirmos el elemento del arreglo en empresaVideojuegos a través de un cast
                        empresaTemporal = (EmpresaVideoJuegos)lasEmpresas[i];

                        //ahora si se puede acceder a los atributos específicos de esta clase
                        TotalJuegosPublicadosMunicipio[j] += empresaTemporal.JuegosPublicados;
                    }


            //Finalmente, creamos el string con la información solicitada
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < losMunicipios.Length; i++)
            {
                resultado.Append("Municipio: " + losMunicipios[i] +
                    ", Total Juegos Publicados: " + TotalJuegosPublicadosMunicipio[i].ToString() +
                    Environment.NewLine);
            }

            return resultado.ToString();
        }

        private string ObtienePorcentajeNoElegiblesMunicipio()
        {
            //dos arreglos para contar las empresas del municipio
            int[] totalEmpresas = new int[losMunicipios.Length]; 
            int[] totalEmpresasNoElegibles = new int[losMunicipios.Length];

            //inicializamos los contadores
            for (int i = 0; i < losMunicipios.Length; i++)
            {
                totalEmpresas[i] = 0;
                totalEmpresasNoElegibles[i] = 0;
            }

            //aqui recorremos las empresas para saber de que municipio son y si no son elegibles
            for (int i = 0; i < lasEmpresas.Length; i++)
            {
                for (int j = 0; j < losMunicipios.Length; j++)
                {
                    if (lasEmpresas[i].Municipio == losMunicipios[j])
                    {
                        totalEmpresas[j]++;
                        if (lasEmpresas[i].EsElegible == false)
                            totalEmpresasNoElegibles[j]++;
                    }
                }
            }

            //Finalmente, creamos el string con la información solicitada
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < losMunicipios.Length; i++)
            {
                resultado.Append("Municipio: " + losMunicipios[i] +
                    ", Porcentaje Empresas no Elegibles: " + (((float)totalEmpresasNoElegibles[i]/totalEmpresas[i]) *100).ToString("0.00") +
                    "%" + Environment.NewLine);
            }

            return resultado.ToString();
        }



        /*
        private string ObtieneMedallasTorneo()
        {
            StringBuilder resultado = new StringBuilder();

            // un arreglo que se encarga de totalizar los participantes por cada torneo
            int[] contadorMedallasTorneo = new int[losTorneos.Length];

            //inicializamos todos los contadores en 0
            for (int i = 0; i < contadorMedallasTorneo.Length; i++)
                contadorMedallasTorneo[i] = 0;

            //recorremos el arreglo de participantes preguntando por su torneo
            for (int i = 0; i < losParticipantes.Length; i++)
                for (int j = 0; j < losTorneos.Length; j++)
                    if (losTorneos[j] == losParticipantes[i].Torneo && losParticipantes[i].EsEntusiasta)
                        contadorMedallasTorneo[j]++;

            int totalMedallas = 0;

            for (int i = 0; i < losTorneos.Length; i++)
            {
                resultado.Append("Torneo: " + losTorneos[i] +
                    ", Medallas: " + contadorMedallasTorneo[i].ToString() +
                    Environment.NewLine);

                totalMedallas += contadorMedallasTorneo[i];
            }

            resultado.Append("Total medallas entregadas: " + totalMedallas.ToString() +
                    Environment.NewLine);

            return resultado.ToString();
        }

        private string ObtienePorcentajeEntusiastasFacultad()
        {
            StringBuilder resultado = new StringBuilder();

            // un arreglo que se encarga de totalizar los participantes por cada torneo
            int[] contadorEntusiastasFacultad = new int[lasFacultades.Length];
            int[] contadorParticipantesFacultad = new int[lasFacultades.Length];
            float[] porcentajeEntusiastasFacultad = new float[lasFacultades.Length];

            //inicializamos todos los contadores en 0
            for (int i = 0; i < contadorParticipantesFacultad.Length; i++)
                contadorParticipantesFacultad[i] = 0;

            for (int i = 0; i < contadorEntusiastasFacultad.Length; i++)
                contadorEntusiastasFacultad[i] = 0;

            //recorremos el arreglo de participantes preguntando por su facultad
            for (int i = 0; i < losParticipantes.Length; i++)
                for (int j = 0; j < lasFacultades.Length; j++)
                    if (lasFacultades[j] == losParticipantes[i].Facultad)
                    {
                        contadorParticipantesFacultad[j]++;

                        if (losParticipantes[i].EsEntusiasta)
                            contadorEntusiastasFacultad[j]++;
                    }

            //aqui calculamos los porcentajes
            for (int i = 0; i < porcentajeEntusiastasFacultad.Length; i++)
            {
                porcentajeEntusiastasFacultad[i] = (float)contadorEntusiastasFacultad[i] * 100 /
                    contadorParticipantesFacultad[i];
            }

            //construimos el string resultado
            for (int i = 0; i < lasFacultades.Length; i++)
            {
                resultado.Append("Facultad: " + lasFacultades[i] +
                    ", Porcentaje entusiastas: " + porcentajeEntusiastasFacultad[i].ToString("0.00") +
                    "%" + Environment.NewLine);
            }

            return resultado.ToString();
        }

        */
    }
}