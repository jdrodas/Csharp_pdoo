namespace Poo_PS_GoF_Iterator
{
    public class Lamina
    {
        private string? nombre;
        private int consecutivo;

        public Lamina(int consecutivo, string nombre)
        {
            this.consecutivo = consecutivo;
            this.nombre = nombre;
        }
        public string Nombre
        {
            get { return nombre!; }
        }

        public int Consecutivo
        {
            get { return consecutivo; }
        }

        public override string ToString()
        {
            string informacion = $"No. {consecutivo} \n" +
                $"Nombre: {nombre}\n";

            return informacion;
        }
    }
}