﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutasNutritivas
{
    class Fruta
    {
        //atributos
        protected int azucar;
        protected float fibra, proteina;
        protected string tipo;
        protected bool saludable;

        //aqui vienen los constructores
        public Fruta()
        {
            azucar = 0;
            fibra = 0f;
            proteina = 0f;
            tipo = "";
            saludable = false;
        }

        public Fruta(int azucar, float fibra, float proteina, string tipo)
        {
            //aqui usamos las propiedades para aprovechar las validaciones allí implementadas
            Azucar = azucar;
            Fibra = fibra;
            Proteina = proteina;
            this.tipo = tipo;

            ValidaSaludable();

        }

        public bool Saludable
        {
            get { return saludable; }
        }

        //aqui vienen las propiedades
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Azucar
        {
            get { return azucar; }
            set {
                    if (value >= 5 && value <= 60)
                        azucar = value;
                    else
                        azucar = 0;
                }
        }

        public float Fibra
        {
            get { return fibra; }
            set {
                    if (value >= 2.5f && value <= 12.6f)
                        fibra = value;
                    else
                        fibra = 0f;
                }
        }

        public float Proteina
        {
            get { return proteina; }
            set
            {
                if (value >= 0.3f && value <= 5f)
                    proteina = value;
                else
                    proteina = 0f;
            }

        }

        public virtual string InfoNutricional()
        {
            string resultado = ". Azucar: " + azucar + 
                               ". Fibra: " + fibra.ToString("0.00") +
                               ". Proteina: " + proteina.ToString("0.00");
            return resultado;
        }

        public virtual void ValidaSaludable()
        {
            if (azucar <= 15 && fibra >= 4.3f && proteina >= 1.8f)
                saludable = true;
            else
                saludable = false;
        }
    }
}
