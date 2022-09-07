namespace LogicaComercio
{
    public class OvejaLanuda : Oveja
    {
        private int cantidadLana;

        public OvejaLanuda() : base()
        {
            cantidadLana = 0;
        }

        public OvejaLanuda(int peso,
                            int edad,
                            string sexo,
                            int cantidadLana) : base(edad, peso, sexo)
        {
            this.cantidadLana = cantidadLana;
        }
        public int CantidadLana
        {
            get { return cantidadLana; }
            set { cantidadLana = value; }
        }

        public override string ToString()
        {
            string resultado = base.ToString();

            resultado += $"Produce {cantidadLana} Kg de lana\n";

            return resultado;
        }

        public override int Produccion
        {
            get
            {
                if (esApta)
                    return cantidadLana;
                else
                    return 0;
            }            
        }
        public override void EvaluaAptitud()
        {
            if (edad >= 24 && edad <= 84 && peso >= 35)
                esApta = true;
        }
    }
}
