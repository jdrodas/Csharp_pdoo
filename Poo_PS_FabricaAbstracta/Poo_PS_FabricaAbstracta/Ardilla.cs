using System;


namespace Poo_PS_FabricaAbstracta
{
    class Ardilla: Herbivoro
    {
        public Ardilla()
        {
            nombre = "Herbivoro de Asia";
            especie = "Ardilla";
        }

        public override string Alimentarse()
        {
            string resultado = "Este herbívoro de la especie " + especie + " llamado " +
                nombre + " se alimenta de nueces" + Environment.NewLine;

            return resultado;
        }
    }
}
