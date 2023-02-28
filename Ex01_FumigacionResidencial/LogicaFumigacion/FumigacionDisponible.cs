using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaFumigacion
{
    public class FumigacionDisponible : Fumigacion
    {
        private int cantidad;

        public FumigacionDisponible() : base()
        {
            cantidad = 0;
        }

        public FumigacionDisponible(string plaga, 
            string metodoFumigacion) : base(plaga, metodoFumigacion)
        {
            cantidad = 0;
        }

        public FumigacionDisponible(string plaga,
            string metodoFumigacion, int cantidad) : base(plaga, metodoFumigacion)
        {
            this.cantidad = cantidad;
        }

        public int GetCantidad()
        { 
            return cantidad; 
        }

        public void IncrementaCantidad()
        {
            cantidad++;
        }

        public override string ToString()
        {
            string informacion = $"Cantidad: {cantidad}, " +
                $"Plaga: {plaga}, " +
                $"Método: {metodoFumigacion}";
            return informacion;
        }
    }
}
