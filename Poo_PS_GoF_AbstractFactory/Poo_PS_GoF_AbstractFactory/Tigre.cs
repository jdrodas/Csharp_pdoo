using System;

namespace Poo_PS_GoF_AbstractFactory
{
    public class Tigre : Carnivoro
    {
        //Constructor de la clase
        public Tigre()
        {
            nombre = "Joaquin el tigre";
            especie = "Tigre de Bengala";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado = $"Este carnivoro de la especie {especie} " +
                $"llamado {nombre} se alimenta cazando {presa.Especie} " +
                $"que se llama {presa.Nombre}" + Environment.NewLine;

            return resultado;
        }
    }
}
