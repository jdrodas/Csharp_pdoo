namespace LogicaComercio
{
    public class OvejaLechera : Oveja
    {
        private int litrosLeche;

        public OvejaLechera() : base()
        {
            litrosLeche = 0;
        }

        public OvejaLechera(int peso,
                            int edad,
                            string sexo,
                            int litrosLeche) : base(edad, peso, sexo)
        {
            this.litrosLeche = litrosLeche;
        }
        
		public int LitrosLeche
        {
            get { return litrosLeche; }
            set
            {
                litrosLeche = value;
                EvaluaAptitud();
            }
        }

        public override string ToString()
        {
            string resultado = base.ToString();

            resultado += $"Produce {litrosLeche} litros de leche\n";

            return resultado;
        }

        public override void EvaluaAptitud()
        {
            if (edad >= 24 && edad <= 84 && peso >= 35 && litrosLeche >= 2)
                esApta = true;
        }

        public override int Produccion
        {
            get
            {
                if (esApta)
                    return litrosLeche;
                else
                    return 0;
            }

        }
    }
}
