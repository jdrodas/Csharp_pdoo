namespace Poo_PS_GoF_AbstractFactory
{
    public class Gacela: Herbivoro
    {
        //Constructor de la clase
        public Gacela()
        {
            nombre = "Bambi";
            especie = "Gacela";
        }

        public override string Alimentarse()
        {
            string resultado = "Este herbívoro de la especie " + especie + " llamado " +
                nombre + " se alimenta de pasto" + Environment.NewLine;

            return resultado;
        }
    }
}