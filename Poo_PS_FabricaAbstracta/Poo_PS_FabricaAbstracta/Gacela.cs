using System;

namespace Poo_PS_FabricaAbstracta
{
    class Gacela: Herbivoro
    {
        //Constructor de la clase
        public Gacela()
        {
            nombre = "Herbivoro de Africa";
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
