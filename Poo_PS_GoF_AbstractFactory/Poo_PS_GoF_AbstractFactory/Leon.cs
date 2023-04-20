using System;

namespace Poo_PS_GoF_AbstractFactory
{
    public class Leon:Carnivoro
    {
        //Constructor de la clase
        public Leon()
        {
            nombre = "Mufasa";
            especie = "León";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado = $"Este carnivoro de la especie {especie} " +
                $"llamado {nombre} se alimenta cazando {presa.Especie} " +
                $"que se llama {presa.Nombre} " + Environment.NewLine;

            return resultado;
        }
    }
}
