namespace Poo_PS_GoF_Prototype
{
    public class GestorColores
    {
        private Dictionary<string, PrototipoColor> losColores;

        public GestorColores()
        {
            losColores = new Dictionary<string, PrototipoColor>();
        }

        //Propiedad para acceder y asignar valores al diccionario
        public PrototipoColor this[string llave]
        {
            get { return losColores[llave]; }
            set 
            {
                if (!string.IsNullOrEmpty(llave))
                {
                    losColores.Add(llave, value);
                    losColores[llave].Nombre = llave;
                }
            }
        }
    }
}
