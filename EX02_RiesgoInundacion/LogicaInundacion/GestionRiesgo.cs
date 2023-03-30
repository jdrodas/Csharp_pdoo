namespace LogicaInundacion
{
    public class GestionRiesgo
    {
        private int cantidadZonas;
        private Zona[] lasZonas;
        private string[] lasUbicaciones;
        private string[] losTiposDeZona;
        private string[] losTiposDeRiesgos;

        public GestionRiesgo(int cantidadZonas)
        {
            this.cantidadZonas = cantidadZonas;
            lasUbicaciones = InicializaUbicaciones();
            losTiposDeZona = InicializaTiposZona();
            losTiposDeRiesgos = InicializaTiposRiesgos();

            lasZonas = InicializaZonas();

            //Se evalua el riesgo de las zonas
            EvaluaRiesgoZonas(lasZonas);
        }

        /// <summary>
        /// Constructor predeterminado -- Inicializa una zona
        /// </summary>
        public GestionRiesgo()
        {
            this.cantidadZonas = 1;
            lasZonas = new Zona[cantidadZonas];
            lasUbicaciones = InicializaUbicaciones();
            losTiposDeZona = InicializaTiposZona();
            losTiposDeRiesgos = InicializaTiposRiesgos();

            //Se evalua el riesgo de las zonas
            EvaluaRiesgoZonas(lasZonas);
        }

        public Zona[] InicializaZonas()
        {
            Zona[] arregloZonas = new Zona[cantidadZonas];

            int nivelMar, distanciaRio, totalHabitantes;
            double areapoblacion;
            string unaUbicacion, unTipoZona;

            Random rnd = new Random();

            for (int i = 0; i < arregloZonas.Length; i++)
            {
                nivelMar = rnd.Next(0, 3001);
                distanciaRio = rnd.Next(0, 2001);
                totalHabitantes = rnd.Next(1000, 1000001);
                areapoblacion = rnd.NextDouble() * 50;
                unaUbicacion = lasUbicaciones[rnd.Next(lasUbicaciones.Length)];
                unTipoZona = losTiposDeZona[rnd.Next(losTiposDeZona.Length)];


                arregloZonas[i] = new Zona(
                    nivelMar,
                    distanciaRio,
                    totalHabitantes,
                    areapoblacion,
                    unaUbicacion,
                    unTipoZona);
            }

            return arregloZonas;
        }

        public void InicializaZonas(Zona[] lasZonas)
        {
            //Se evalua el riesgo de las zonas
            EvaluaRiesgoZonas(lasZonas);

            //finalmente, se asigna al atributo
            this.lasZonas = lasZonas;
            this.cantidadZonas = lasZonas.Length;
        }

        private string[] InicializaUbicaciones()
        {
            string[] arregloUbicaciones = { "Costera", "Montañosa" };
            return arregloUbicaciones;
        }

        private string[] InicializaTiposZona()
        {
            string[] arregloTipos = { "Rural", "Urbana" };
            return arregloTipos;
        }

        private string[] InicializaTiposRiesgos()
        {
            string[] arregloRiesgos = {
                "Riesgo inundación fluvial",
                "Riesgo inundación costera",
                "Riesgo inundación urbana"
            };
            return arregloRiesgos;

        }

        private void EvaluaRiesgoZonas(Zona[] arregloZonas)
        {
            //Para cada zona, se evalua su riesgo de acuerdo a los requerimientos
            for (int i = 0; i < arregloZonas.Length; i++)
            {
                //Evaluación de riesgo fluvial: losTiposDeRiesgos[0]
                if (arregloZonas[i].DistanciaRio < 50 && arregloZonas[i].Ubicacion == "Montañosa")
                    arregloZonas[i].LosRiesgos.Add(losTiposDeRiesgos[0]);

                //Evaluamos Riesgo Costero: losTiposDeRiesgos[1]
                if (arregloZonas[i].Ubicacion == "Costera" && arregloZonas[i].NivelMar < 10)
                    arregloZonas[i].LosRiesgos.Add(losTiposDeRiesgos[1]);

                //Evaluamos Riesgo Urbano: losTiposDeRiesgos[2]
                if (arregloZonas[i].TipoZona == "Urbana" && arregloZonas[i].DensidadPoblacional >= 100)
                    arregloZonas[i].LosRiesgos.Add(losTiposDeRiesgos[2]);

                if (arregloZonas[i].LosRiesgos.Count > 0)
                    arregloZonas[i].EstaEnRiesgo = true;
                else
                    arregloZonas[i].EstaEnRiesgo = false;
            }
        }


        public string ObtieneInformacionZonas()
        {
            string resultado = $"Total Zonas monitoreadas: {cantidadZonas} \n";

            for (int i = 0; i < lasZonas.Length; i++)
                resultado += $"Zona No. {i + 1}\n{lasZonas[i].ToString()}\n\n";

            return resultado;
        }

        public float ObtienePorcentajeZonasEnRiesgo()
        {
            float porcentaje = 0;
            float totalZonasEnRiesgo = 0;

            foreach (Zona unaZona in lasZonas)
            {
                if (unaZona.EstaEnRiesgo)
                    totalZonasEnRiesgo++;
            }

            porcentaje = (totalZonasEnRiesgo / cantidadZonas) * 100;

            return porcentaje;
        }

        public string ObtienePorcentajeZonasEnRiesgoPorTipoZona()
        {
            float[] valoresPorcentajes = new float[losTiposDeZona.Length];

            for (int i = 0; i < valoresPorcentajes.Length; i++)
                valoresPorcentajes[i] = 0;

            //Recorremos la colección de zonas, preguntando si está en riesgo y que en tipo de zona está
            for (int i = 0; i < lasZonas.Length; i++)
            {
                if (lasZonas[i].EstaEnRiesgo)
                {
                    for (int j = 0; j < losTiposDeZona.Length; j++)
                    {
                        if (lasZonas[i].TipoZona == losTiposDeZona[j])
                        {
                            valoresPorcentajes[j]++;
                        }
                    }
                }
            }

            string informacionPorcentajes = "";

            //Luego de totalizado, calculamos el porcentaje
            for (int i = 0; i < valoresPorcentajes.Length; i++)
            {
                informacionPorcentajes += $"{losTiposDeZona[i]}: {valoresPorcentajes[i]}, ";

                valoresPorcentajes[i] =
                    (valoresPorcentajes[i] / cantidadZonas) * 100;

                informacionPorcentajes += $"que equivale a {valoresPorcentajes[i].ToString("0.00")}% \n";
            }

            return informacionPorcentajes;
        }

        public string ObtienePorcentajeZonasEnRiesgoPorTipoRiesgo()
        {
            float[] valoresPorcentajes = new float[losTiposDeRiesgos.Length];

            for (int i = 0; i < valoresPorcentajes.Length; i++)
                valoresPorcentajes[i] = 0;

            //Recorremos la colección de zonas, preguntando si está en riesgo y que en tipo de riesgo está 
            for (int i = 0; i < lasZonas.Length; i++)
            {
                if (lasZonas[i].EstaEnRiesgo)
                {
                    for (int j = 0; j < losTiposDeRiesgos.Length; j++)
                    {
                        if (lasZonas[i].LosRiesgos.Contains(losTiposDeRiesgos[j]))
                        {
                            valoresPorcentajes[j]++;
                        }
                    }
                }
            }

            string informacionPorcentajes = "";

            //Luego de totalizado, calculamos el porcentaje
            for (int i = 0; i < valoresPorcentajes.Length; i++)
            {
                informacionPorcentajes += $"{losTiposDeRiesgos[i]}: {valoresPorcentajes[i]}, ";

                valoresPorcentajes[i] =
                    (valoresPorcentajes[i] / cantidadZonas) * 100;

                informacionPorcentajes += $"que equivale a {valoresPorcentajes[i].ToString("0.00")}% \n";
            }

            return informacionPorcentajes;
        }
    }
}