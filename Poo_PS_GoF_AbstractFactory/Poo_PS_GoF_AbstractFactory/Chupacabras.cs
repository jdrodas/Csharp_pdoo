using System;

namespace Poo_PS_GoF_AbstractFactory
{
    internal class Chupacabras : Carnivoro
    {
        //Constructor de la clase
        public Chupacabras()
        {
            nombre = "Cholo";
            especie = "Chupacabras criptido";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado = $"Este carnivoro de la especie {especie} " +
                $"llamado {nombre} se alimenta desangrando {presa.Especie} " +
                $"que se llama {presa.Nombre} " + Environment.NewLine;

            return resultado;
        }
    }
}
