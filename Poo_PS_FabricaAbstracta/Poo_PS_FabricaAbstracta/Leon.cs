using System;

namespace Poo_PS_FabricaAbstracta
{
    class Leon:Carnivoro
    {
        //Constructor de la clase
        public Leon()
        {
            nombre = "Carnivoro de Africa";
            especie = "León";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado ="Este carnívoro de la especie " + especie + " llamado " +
                    nombre + " se alimenta cazando " + presa.Especie + " que se llama " +
                    presa.Nombre + Environment.NewLine;

            return resultado;
        }
    }
}
