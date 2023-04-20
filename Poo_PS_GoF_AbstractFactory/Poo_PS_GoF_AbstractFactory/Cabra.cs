using System;

namespace Poo_PS_GoF_AbstractFactory
{
    public class Cabra : Herbivoro
    {
        public Cabra()
        {
            nombre = "Marianito";
            especie = "cabra de la sabana";
        }

        public override string Alimentarse()
        {
            string resultado = $"Este herbívoro de la especie {especie} " +
                $"llamado {nombre} se alimenta de lamer las piedras." + Environment.NewLine;
            return resultado;
        }
    }
}
