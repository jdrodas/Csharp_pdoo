
namespace ComercioOvejas
{
    public class Oveja
    {
        protected int edad;
        protected int peso;
        protected string sexo;
        protected int cantidadLana;

        public Oveja()
        {
            edad= 0;
            peso= 0;
            sexo = "";
            cantidadLana = 0;
        }

        public Oveja(int edad, int peso, string sexo, int cantidadLana)
        {
            this.edad = edad;
            this.peso = peso;
            this.sexo = sexo;
            this.cantidadLana = cantidadLana;
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Peso
        {
            get { return peso;}
            set { peso = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int CantidadLana
        {
            get { return cantidadLana; }
            set { cantidadLana = value; }
        }

        public override string ToString()
        {
            string informacion = $"Esta oveja es {sexo}\n" +
                $"tiene {edad} meses de edad\n" +
                $"pesa {peso} kgs\n";

            if (sexo == "Macho")
                informacion += $"Tiene {cantidadLana} kgs de lana\n";

            return informacion;
        }
    }
}
