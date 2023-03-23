namespace LogicaInundacion
{
    public class Zona
    {
        private bool estaEnRiesgo;
        private int nivelMar, distanciaRio, totalHabitantes;
        private double areaPoblacion, densidadPoblacional;
        private string ubicacion, tipoZona;        
        private List<string> losRiesgos;

        public Zona()
        {
            losRiesgos = new List<string>();
            nivelMar = 0;
            distanciaRio = 0;
            totalHabitantes = 0;
            areaPoblacion = 0;
            densidadPoblacional = 0;
            ubicacion = string.Empty;
            tipoZona = "";

            EvaluaRiesgo();
        }

        public Zona(int nivelMar, 
                    int distanciaRio, 
                    int totalHabitantes, 
                    double areaPoblacion,
                    string ubicacion,
                    string tipoZona)
        {
            this.nivelMar = nivelMar;
            this.distanciaRio = distanciaRio;
            this.totalHabitantes = totalHabitantes;
            this.areaPoblacion = areaPoblacion;
            this.ubicacion = ubicacion;
            this.tipoZona = tipoZona;

            densidadPoblacional = (double)totalHabitantes / areaPoblacion;
            losRiesgos = new List<string>();

            EvaluaRiesgo();
        }

        public bool GetEstadoRiesgo()
        { 
            return estaEnRiesgo; 
        }

        private void EvaluaRiesgo()
        {
            //Evaluamos Riesgo Fluvial
            if (distanciaRio < 50 && ubicacion == "Montañosa")
                losRiesgos.Add("Riesgo inundación fluvial");

            //Evaluamos Riesgo Costero
            if (ubicacion == "Costera" && nivelMar < 10)
                losRiesgos.Add("Riesgo inundacion costera");

            //Evaluamos Riesgo Urbano
            if (tipoZona == "Urbana" && densidadPoblacional >= 100)
                losRiesgos.Add("Riesgo inundación urbana");

            if (losRiesgos.Count > 0)
                estaEnRiesgo = true;
            else
                estaEnRiesgo = false;
        }

        public override string ToString()
        {
            string informacion = $"Esta es una zona ubicada en {ubicacion} del tipo {tipoZona}, " +
                $"con un nivel del mar de {nivelMar} mts, y a una distancia del rio de {distanciaRio}, " +
                $"tiene {totalHabitantes} habitantes y un área de {areaPoblacion}, " +
                $"con una densidad de {densidadPoblacional}.\n";

            if (!estaEnRiesgo)
                informacion += "No está en riesgo";
            else
            {
                informacion += "Está en riesgo de:";

                foreach (string riesgo in losRiesgos)
                    informacion += $"\n\t {riesgo}";
            }

            return informacion;
        }
    }
}