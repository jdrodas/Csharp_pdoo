namespace ComercioOvejas
{
    public abstract class Oveja
    {
        protected int edad;
        protected int peso;
        protected string sexo;
        protected bool esApta;


        public Oveja()
        {
            edad= 0;
            peso= 0;
            sexo = "";
            esApta= false;
        }

        public Oveja(int edad, int peso, string sexo)
        {
            this.edad = edad;
            this.peso = peso;
            this.sexo = sexo;
        }

        public int Edad
        {
            get { return edad; }
            set 
            {
                edad = value;
                EvaluaAptitud();
            }
        }

        public int Peso
        {
            get { return peso;}
            set
            {
                peso = value;
                EvaluaAptitud();
            }
        }

        public string Sexo
        {
            get { return sexo; }
            set
            {
                sexo = value;
                EvaluaAptitud();
            }
        }

        public bool EsApta
        {
            get { return esApta; }
        }

        public abstract void EvaluaAptitud();

        public abstract int Produccion
        {
            get;
        }


        public override string ToString()
        {
            string informacion = $"Esta oveja es {sexo}\n" +
                $"tiene {edad} meses de edad\n" +
                $"pesa {peso} kgs\n";

            return informacion;
        }


    }
}
