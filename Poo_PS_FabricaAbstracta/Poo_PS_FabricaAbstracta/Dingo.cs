using System;


namespace Poo_PS_FabricaAbstracta
{
    class Dingo: Carnivoro
    {
        //Constructor de la clase
        public Dingo()
        {
            nombre = "Carnivoro de Oceanía";
            especie = "Dingo";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado = "Este carnívoro de la especie " + especie + " llamado " +
                    nombre + " se alimenta cazando " + presa.Especie + " que se llama " +
                    presa.Nombre + Environment.NewLine;

            return resultado;
        }
    }
}
