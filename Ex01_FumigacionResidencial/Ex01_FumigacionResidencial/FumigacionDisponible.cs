using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_FumigacionResidencial
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
