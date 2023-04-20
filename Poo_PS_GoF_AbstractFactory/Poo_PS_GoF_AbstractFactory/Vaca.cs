using System;

namespace Poo_PS_GoF_AbstractFactory
{
    public class Vaca : Herbivoro
    {
        public Vaca()
        {
            nombre = "Lola la vaca";
            especie = "Vaca lechera";
        }

        public override string Alimentarse()
        {
            string resultado = $"Este herbívoro de la especie {especie} " +
                $"llamado {nombre} se alimenta de pasto." + Environment.NewLine;
            return resultado;
        }
    }
}
