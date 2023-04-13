using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FabricaMotocicletas
{
    public class MotocicletaDeportiva : Motocicleta, Vendible
    {
        private string tipoMotor;
        private int peso;
        private bool frenosDisco;

        public MotocicletaDeportiva(int velocidadMaxima, string tipoMotor, int peso, bool frenosDisco,
            int potenciaMotor, double precio, string descripcion, 
            double capacidadTanque): base(velocidadMaxima,capacidadTanque,potenciaMotor)
        {
            this.tipoMotor = tipoMotor;
            this.peso = peso;
            this.frenosDisco = frenosDisco;
            this.velocidadActual = 0;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public override void Acelerar()
        {
            if((velocidadActual +10)<=velocidadMaxima)
                velocidadActual += 10;
        }

        public override void Frenar()
        {
            if((velocidadActual-10)>=0)
                velocidadActual -= 10;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }
    }
}
