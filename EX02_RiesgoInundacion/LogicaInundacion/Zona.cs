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
            
            estaEnRiesgo = false;
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

            if (areaPoblacion == 0)
                densidadPoblacional = 0;
            else
                densidadPoblacional = (double)totalHabitantes / areaPoblacion;
            
            losRiesgos = new List<string>();
            estaEnRiesgo = false;
        }

        // Propiedades para acceso a los atributos
        public bool EstaEnRiesgo
        {
            get { return estaEnRiesgo; }
            set { estaEnRiesgo = value;}
        }

        public string TipoZona
        {
            get { return tipoZona; }
        }

        public string Ubicacion
        {
            get { return ubicacion; }
        }

        public int NivelMar
        {
            get { return nivelMar; }
        }

        public int DistanciaRio
        {
            get { return distanciaRio; }
        }

        public double DensidadPoblacional
        {
            get { return densidadPoblacional; }
        }

        public List<string> LosRiesgos
        {
            get { return losRiesgos; }
        }
        public override string ToString()
        {
            string informacion = $"Esta es una zona {ubicacion} del tipo {tipoZona},\n " +
                $"con un nivel del mar de {nivelMar} mts, y a una distancia del rio de {distanciaRio},\n " +
                $"tiene {totalHabitantes} habitantes y un área de {areaPoblacion.ToString(".00")},\n " +
                $"con una densidad de {densidadPoblacional.ToString(".00")}.\n";

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