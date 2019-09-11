using System;
using System.Text;

namespace ex02_TorneoE_Sports
{
    class RegistroParticipantes
    {
        //Atributos de la clase
        private Jugador[] losParticipantes;
        private string[] losTorneos, lasFacultades;

        //El constructor de la clase
        public RegistroParticipantes()
        {
            losParticipantes = new Jugador[600];

            losTorneos = new string[] { "Combates fantásticos",
                                    "Carreras automovilísticas",
                                    "Platformers"};

            lasFacultades = new string[] {
                "MCIA",
                "MCIB",
                "MCIC",
                "MCIE",
                "MCIG",
                "MCII",
                "MCIL",
                "MCIM",
                "MCIO",
                "MCIQ",
                "MCIT",
                "MCNT"};

            //Inicializamos el arreglo según las reglas definidas
            InicializaSimulacion();
        }

        public void InicializaSimulacion()
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            int datoTorneo, datoFacultad;

            //aqui inicializamos el arreglo de manera aleatoria
            for (int i = 0; i < losParticipantes.Length; i++)
            {
                datoTorneo = aleatorio.Next(losTorneos.Length);
                datoFacultad = aleatorio.Next(lasFacultades.Length);

                //dependiendo del torneo asignado, se inicializa con el constructor de la clase
                //de ese tipo de jugador
                switch (datoTorneo)
                {
                    case 0: //Combates fantásticos
                        losParticipantes[i] = new JugadorCombate(aleatorio.Next(101),
                                                                 aleatorio.Next(101),
                                                                 lasFacultades[datoFacultad],
                                                                 losTorneos[datoTorneo]);
                        break;

                    case 1: //Carreras automovilísticas
                        losParticipantes[i] = new JugadorCarrera(aleatorio.Next(21),
                                                                 aleatorio.Next(1001),
                                                                 lasFacultades[datoFacultad],
                                                                 losTorneos[datoTorneo]);
                        break;

                    case 2: //Combates Platformers
                        losParticipantes[i] = new JugadorPlatformer(aleatorio.Next(25),
                                                                 aleatorio.Next(1001),
                                                                 lasFacultades[datoFacultad],
                                                                 losTorneos[datoTorneo]);
                        break;
                }

                losParticipantes[i].EvaluaEntusiasmo();
            }
        }

        public string InformacionParticipacion()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("Resultados de la ejecución:" + Environment.NewLine + Environment.NewLine);
            resultado.Append("Porcentaje de jugadores con medalla por facultad:" + Environment.NewLine + Environment.NewLine);
            resultado.Append(ObtienePorcentajeEntusiastasFacultad());

            resultado.Append(Environment.NewLine + "Total medallas entregadas en el torneo:" + Environment.NewLine + Environment.NewLine);
            resultado.Append(ObtieneMedallasTorneo());

            resultado.Append(Environment.NewLine + "Total participantes en cada torneo:" + Environment.NewLine + Environment.NewLine);
            resultado.Append(ObtieneParticipantesTorneo());

            return resultado.ToString();
        }

        private string ObtieneParticipantesTorneo()
        {
            StringBuilder resultado = new StringBuilder();

            // un arreglo que se encarga de totalizar los participantes por cada torneo
            int[] contadorParticipantesTorneo = new int[losTorneos.Length];

            //inicializamos todos los contadores en 0
            for (int i = 0; i < contadorParticipantesTorneo.Length; i++)
                contadorParticipantesTorneo[i] = 0;

            //recorremos el arreglo de participantes preguntando por su torneo
            for (int i = 0; i < losParticipantes.Length; i++)
                for (int j = 0; j < losTorneos.Length; j++)
                    if (losTorneos[j] == losParticipantes[i].Torneo)
                        contadorParticipantesTorneo[j]++;

            for (int i = 0; i < losTorneos.Length; i++)
            {
                resultado.Append("Torneo: " + losTorneos[i] +
                    ", participantes: " + contadorParticipantesTorneo[i].ToString() +
                    Environment.NewLine);
            }

            return resultado.ToString();
        }

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
    }
}
