namespace LogicaComercio
{
    public class Cooperativa
    {
        private Oveja[] lasOvejas;
        private float comisionVentaLeche, comisionVentaLana;
        private float valorVentaLeche, valorVentaLana;
        private float porcentajeComision;
        private int precioLitroLeche, precioKiloLana;
        private int totalOvejasLanudasAptas, totalOvejasLecherasAptas;
        private int totalOvejasLanudas, totalOvejasLecheras;
        private int totalLecheProducida, totalLanaProducida;
        private float porcentajeLanudasAptas, porcentajeLecherasAptas;

        public int TotalOvejasLanudasAptas
        {
            get { return totalOvejasLanudasAptas; }
        }

        public int TotalLecheProducida
        {
            get { return totalLecheProducida; }
        }
        
        public float TotalComisionCooperativa
        {
            get { return (comisionVentaLana + comisionVentaLeche); }
        }        
        
        public float TotalPagoGranjero
        {
            get { return (valorVentaLana + valorVentaLeche); }
        }

        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public Cooperativa()
        {
            lasOvejas = new Oveja[1000];
            precioKiloLana = 800;
            precioLitroLeche = 1500;
            porcentajeComision = 0.05f;

            totalOvejasLecheras = 0;
            totalOvejasLanudas = 0;
            totalOvejasLanudasAptas = 0;
            totalOvejasLecherasAptas = 0;
            porcentajeLanudasAptas = 0;
            porcentajeLecherasAptas = 0;

            totalLecheProducida = 0;
            totalLanaProducida = 0;

            comisionVentaLana = 0;
            comisionVentaLeche = 0;
            valorVentaLana = 0;
            valorVentaLeche = 0;
        }

        /// <summary>
        /// Constructor de la clase con los valores de los precios y el arreglo de ovejas
        /// </summary>
        /// <param name="arregloOvejas"></param>
        /// <param name="precioLitroLeche">Precio del litro de leche</param>
        /// <param name="precioKiloLana">Precio del kilo de lana</param>
        /// <param name="porcentajeComision">Porcentaje de comisión de la cooperativa</param>
        public Cooperativa(Oveja[] arregloOvejas, int precioLitroLeche, int precioKiloLana, float porcentajeComision)
        {
            lasOvejas = arregloOvejas;
            this.precioKiloLana = precioKiloLana;
            this.precioLitroLeche = precioLitroLeche;
            this.porcentajeComision = porcentajeComision;

            totalOvejasLecheras = 0;
            totalOvejasLanudas = 0;
            totalOvejasLanudasAptas = 0;
            totalOvejasLecherasAptas = 0;
            porcentajeLanudasAptas = 0;
            porcentajeLecherasAptas = 0;

            totalLecheProducida = 0;
            totalLanaProducida = 0;

            comisionVentaLana = 0;
            comisionVentaLeche = 0;
            valorVentaLana = 0;
            valorVentaLeche = 0;
        }        

        /// <summary>
        /// Función que simula la recepción de las ovejas
        /// </summary>
        public void RecepcionOvejas()
        {
            //Aqui inicializamos las ovejas
            Random aleatorio = new Random();

            string[] losSexos = { "Macho", "Hembra" };
            string elSexo;

            //Aqui inicializamos el arreglo de Ovejas
            for (int i = 0; i < lasOvejas.Length; i++)
            {
                elSexo = losSexos[aleatorio.Next(losSexos.Length)];

                if (elSexo == "Macho")
                {
                    lasOvejas[i] = new OvejaLanuda()
                    {
                        Edad = aleatorio.Next(0, 100),
                        Peso = aleatorio.Next(20, 100),
                        Sexo = elSexo,
                        CantidadLana = aleatorio.Next(1, 10)
                    };
                }
                else
                {
                    lasOvejas[i] = new OvejaLechera()
                    {
                        Edad = aleatorio.Next(0, 100),
                        Peso = aleatorio.Next(20, 100),
                        Sexo = elSexo,
                        LitrosLeche = aleatorio.Next(1, 6)
                    };
                }
            }            

        }

        /// <summary>
        /// Realiza el proceso de identificación de las ovejas aptas del rebaño del granjero
        /// </summary>
        public void IdentificaOvejasAptas()
        {
            totalOvejasLanudasAptas = 0;
            totalOvejasLecherasAptas = 0;
            totalOvejasLanudas = 0;
            totalOvejasLecheras = 0;
            
            foreach (Oveja unaOveja in lasOvejas)
            {
                if (unaOveja.EsApta)
                    if (unaOveja.Sexo == "Macho")
                        totalOvejasLanudasAptas++;
                    else
                        totalOvejasLecherasAptas++;

                if (unaOveja.Sexo == "Hembra")
                    totalOvejasLecheras++;
                else
                    totalOvejasLanudas++;

                porcentajeLanudasAptas = ((float)totalOvejasLanudasAptas / totalOvejasLanudas) * 100;
                porcentajeLecherasAptas = ((float)totalOvejasLecherasAptas / totalOvejasLecheras) * 100;
            }
        }
        
        /// <summary>
        /// Realiza el cálculo de la producción con base en la aptitud de las ovejas
        /// </summary>
        public void CalculaProduccion()
        {
            for (int i = 0; i < lasOvejas.Length; i++)
            {
                if (lasOvejas[i].EsApta)
                    if (lasOvejas[i].Sexo == "Macho")
                        totalLanaProducida += lasOvejas[i].Produccion;
                    else
                        totalLecheProducida += lasOvejas[i].Produccion;
            }
        }

        /// <summary>
        /// Calcula la comisión de venta recolectada por la cooperativa
        /// </summary>
        public void CalculaComisionVenta()
        {
            //Si se intenta calcular comisión sin haber calculado producción
            if (totalLanaProducida == 0 && totalLecheProducida == 0)
                CalculaProduccion();

            comisionVentaLana = totalLanaProducida * precioKiloLana * porcentajeComision;
            comisionVentaLeche = totalLecheProducida * precioLitroLeche * porcentajeComision;
        }

        /// <summary>
        /// Calcula el valor del pago del granjero por la producción de leche y lana
        /// </summary>
        public void CalculaPagoGranjero()
        {
            //Si se intenta calcular el pago al granjero sin calcular 
            //la comisión de la Cooperativa
            if (comisionVentaLana == 0 && comisionVentaLeche == 0)
                CalculaComisionVenta();
            
            valorVentaLeche = (totalLecheProducida * 1500) - comisionVentaLeche;
            valorVentaLana = (totalLanaProducida * 800) - comisionVentaLana;
        }

        /// <summary>
        /// Obtiene la información del proceso de comercio de las ovejas
        /// </summary>
        /// <returns>string con la información solicitada</returns>
        public override string ToString()
        {
            string informe = $"Total de Ovejas en esta simulación: {lasOvejas.Length}\n\n";

            informe += $"El precio del Kg de lana es {precioKiloLana} \n" +
                       $"El precio del litro de leche es {precioLitroLeche} \n" +
                       $"La Cooperativa recibe una comisión del {((porcentajeComision)*100).ToString("0.00")}%\n\n";

            informe += $"Del total de {totalOvejasLanudas} ovejas lanudas, " +
                       $"el {porcentajeLanudasAptas.ToString("0.00")}% son aptas \n" +
                       $"Del total de {totalOvejasLecheras} ovejas lecheras, " +
                       $"el {porcentajeLecherasAptas.ToString("0.00")}% son aptas\n\n";

            informe += $"La producción total de leche " +
                       $"es {totalLecheProducida} Lts \n" +
                       $"La producción total de lana es {totalLanaProducida} Kgs\n\n";

            informe += $"El granjero obtuvo ${valorVentaLana} por lana y ${valorVentaLeche} de leche \n" +
                       $"La Cooperativa ganó ${comisionVentaLana} por lana y ${comisionVentaLeche} por leche\n";

            return informe;
        }
    }
}
