using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaMotocicletas
{
    public abstract class Motocicleta
    {
        protected int velocidadMaxima;
        protected double capacidadTanque;
        protected int potenciaMotor;
        protected int velocidadActual;
        protected double precio;Set
        protected string descripcion;

        public Motocicleta(int velocidadMaxima, double capacidadTanque, int potenciaMotor)
        {
            if (velocidadMaxima < 0)
            {
                throw new ArgumentException("La velocidad máxima debe ser un número entero positivo");
            }

            this.velocidadMaxima = velocidadMaxima;
            this.capacidadTanque = capacidadTanque;
            this.potenciaMotor = potenciaMotor;
            this.velocidadActual = 0;
            this.precio = 0f;
            this.descripcion = string.Empty;
        }

        public int GetVelocidadMaxima()
        {
            return velocidadMaxima;
        }

        public int GetVelocidadActual()
        {
            return velocidadActual;
        }

        public void SetVelocidadMaxima(int velocidadMaxima)
        {
            if (velocidadMaxima < 0)
            {
                throw new ArgumentException("La velocidad máxima debe ser un número entero positivo");
            }

            this.velocidadMaxima = velocidadMaxima;
        }

        public double GetCapacidadTanque()
        {
            return capacidadTanque;
        }

        public void SetCapacidadTanque(double capacidadTanque)
        {
            this.capacidadTanque = capacidadTanque;
        }

        public int GetPotenciaMotor()
        {
            return potenciaMotor;
        }

        public void SetPotenciaMotor(int potenciaMotor)
        {
            this.potenciaMotor = potenciaMotor;
        }

        public abstract void Acelerar();
        public abstract void Frenar();
    }

}
