using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeZapatos_POO
{
    public class Tienda
    {
        //Zona de atributos
        private int cantidadZapatos;
        private Zapato[] losZapatos;
        private string[] losEstilos, losColores;
        private int[] lasTallas;
        private bool estaLista;

        //Zona de Constructores

        /// <summary>
        /// Constructor Predeterminado de la clase
        /// </summary>
        public Tienda()
        {
            cantidadZapatos= 0;
            estaLista = false;
            InicializaArreglos();
        }

        /// <summary>
        /// Sobrecarga del constructor utilizando parametro inicial
        /// </summary>
        /// <param name="cantidadZapatos"></param>
        public Tienda(int cantidadZapatos)
        {
            if (cantidadZapatos > 0)
                this.cantidadZapatos = cantidadZapatos;
            else
            {
                this.cantidadZapatos = 0;
                estaLista = false;
            }

            InicializaArreglos();
        }

        /// <summary>
        /// Inicializa los arreglos que tienen los valores a utilizar en la tienda
        /// </summary>
        private void InicializaArreglos()
        {
            losEstilos = new string[]{
                "Tenis",
                "Botas",
                "Crocs Metaleras",
                "Mocasines",
                "Sandalia Gladiadora" };

            losColores = new string[]
            {
                "Verde Selva",
                "Azul Petróleo",
                "Rojo Sangre",
                "Café derrumbe de montaña"
            };

            lasTallas = new int[] { 28, 30, 32, 34, 36, 38, 40, 42, 44 };

            //Aqui inicializamos el arreglo de los zapatos
            //Siempre y cuando tengamos una cantidad válida

            if (cantidadZapatos > 0)
            {
                losZapatos = new Zapato[cantidadZapatos];
                Random aleatorio = new Random();

                for (int i = 0; i < losZapatos.Length; i++)
                {
                    losZapatos[i] = new Zapato();

                    losZapatos[i].Talla = lasTallas[aleatorio.Next(lasTallas.Length)];
                    losZapatos[i].Color = losColores[aleatorio.Next(losColores.Length)];
                    losZapatos[i].Estilo = losEstilos[aleatorio.Next(losEstilos.Length)];
                }

                //La tienda está lista para vender
                estaLista = true;
            }
        }

        /// <summary>
        /// Obtiene el arreglo de colores de los zapatos de la tienda
        /// </summary>
        /// <returns>arreglo de strings con los valores</returns>
        public string[] GetColores()
        {
            return losColores;
        }

        public string[] LosColores
        {
            get { return losColores; }
        }

        /// <summary>
        /// Obtiene el arreglo de estilos de los zapatos de la tienda
        /// </summary>
        /// <returns>arreglo de strings con los valores</returns>
        public string[] GetEstilos()
        {
            return losEstilos;
        }

        public string[] LosEstilos
        {
            get { return losEstilos; } 
        }

        /// <summary>
        /// Obtiene el arreglo de tallas de los zapatos de la tienda
        /// </summary>
        /// <returns>arreglo de int con los valores</returns>
        public int[] GetTallas()
        {
            return lasTallas;
        }

        public int[] LasTallas
        {
            get { return lasTallas; }
        }

        /// <summary>
        /// Obtiene el arreglo de zapatos de la tienda
        /// </summary>
        /// <returns>arreglo de zapatos con los valores</returns>
        public Zapato[] LosZapatos
        {
            get { return losZapatos;}
        }

        public Zapato[] GetZapatos()
        {
            return losZapatos;
        }

        /// <summary>
        /// Obtiene el Zapato de Moda según el estilo
        /// </summary>
        /// <returns>El zapato con el estilo de moda</returns>
        public ZapatoModa ObtieneEstiloModa()
        {
            ZapatoModa zapatoResultado = CalculaEstiloMayor(losZapatos, losEstilos);
            return zapatoResultado;
        }

        /// <summary>
        /// Calcula cual es el zapato de moda de acuerdo al estilo
        /// </summary>
        /// <param name="arregloZapatos">Arreglo de Zapatos</param>
        /// <param name="arregloEstilos">Arreglo de estilos</param>
        /// <returns></returns>
        public ZapatoModa CalculaEstiloMayor(Zapato[] arregloZapatos, string[] arregloEstilos)
        {
            int[] contadorEstilos = new int[arregloEstilos.Length];

            //Precaución: Garantiza que todos los contadores inicien en 0
            for (int i = 0; i < contadorEstilos.Length; i++)
                contadorEstilos[i] = 0;

            //Aqui recorremos los arreglos de estilo y zapato
            for (int i = 0; i < arregloEstilos.Length; i++)
            {
                for (int j = 0; j < arregloZapatos.Length; j++)
                {
                    if (arregloEstilos[i] == arregloZapatos[j].GetEstilo())
                        contadorEstilos[i]++;
                }
            }

            //Aqui identificamos el mayor, el estilo que más zapatos tiene, el primero de ellos
            int valorMayor = contadorEstilos[0];
            int posicionMayor = 0;

            for (int i = 1; i < contadorEstilos.Length; i++)
            {
                if (contadorEstilos[i] > valorMayor)
                {
                    valorMayor = contadorEstilos[i];
                    posicionMayor = i;
                }
            }

            //Aqui declaramos el objeto resultado
            ZapatoModa zapatoResultado = new ZapatoModa();

            zapatoResultado.SetCantidad(valorMayor);
            zapatoResultado.SetEstilo(losEstilos[posicionMayor]);

            return zapatoResultado;
        }
    }
}
