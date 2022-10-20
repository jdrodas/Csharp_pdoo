﻿namespace Poo_PS_GoF_AbstractFactory
{
    public class Koala : Herbivoro
    {
        public Koala()
        {
            nombre = "Herbivoro de Oceanía";
            especie = "Koala";
        }

        public override string Alimentarse()
        {
            string resultado = "Este herbívoro de la especie " + especie + " llamado " +
                nombre + " se alimenta de hojas de eucalipto" + Environment.NewLine;

            return resultado;
        }
    }
}
