namespace Poo_PS_FabricaAbstracta
{
    public class MundoAnimal
    {
        //Atributos
        private Continente unContinente;
        private Carnivoro unCarnivoro;
        private Herbivoro unherbivoro;

        //Constructor de la clase
        public MundoAnimal(string nombreContinente)
        {
            unContinente = SeleccionaContinente(nombreContinente);
            unCarnivoro = unContinente.CrearCarnivoro();
            unherbivoro = unContinente.CrearHerbivoro();
        }

        public Continente SeleccionaContinente(string nombre)
        {
            Continente continenteSeleccionado;

            switch (nombre)
            {
                case "Asia":
                    continenteSeleccionado = new ContinenteAsia();
                    continenteSeleccionado.Nombre = "Asia";
                    break;

                case "America":
                    continenteSeleccionado = new ContinenteAmerica();
                    continenteSeleccionado.Nombre = "America";
                    break;

                case "Africa":
                    continenteSeleccionado = new ContinenteAfrica();
                    continenteSeleccionado.Nombre = "Africa";
                    break;

                case "Oceania":
                    continenteSeleccionado = new ContinenteOceania();
                    continenteSeleccionado.Nombre = "Oceania";
                    break;


                //De manera predeterminada, si no se especifica continente
                //se creará un continente de Asia
                default:
                    continenteSeleccionado = new ContinenteAsia();
                    continenteSeleccionado.Nombre = "Asia";
                    break;
            }

            return continenteSeleccionado;
        }

        public string ResultadoCadenaAlimenticia()
        {
            string resultado = $"En el continente {unContinente.Nombre} " +
                $"la cadena alimenticia funciona asi:\n";

            resultado += unherbivoro.Alimentarse();
            resultado += unCarnivoro.Cazar(unherbivoro) + "\n";
            return resultado;
        }
    }
}
