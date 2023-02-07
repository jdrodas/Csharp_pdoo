namespace FabricadorArepas
{
    public class Fabrica
    {
        private int cantidad;
        private string[] tiposMasa;
        private Arepa[] lasArepas;

        public Fabrica()
        {
            cantidad = 1; //Valor arbitrario y predeterminado para que produzca al menos 1 arepa
            tiposMasa = AsignaTiposMasa();
            lasArepas = AsignaArepas();
        }

        public Fabrica(int cantidad)
        {
            if(cantidad<=0)
                this.cantidad = 1;
            else
                this.cantidad = cantidad;

            tiposMasa = AsignaTiposMasa();
            lasArepas = AsignaArepas();
        }

        private Arepa[] AsignaArepas()
        {
            if (cantidad <= 0)
                cantidad = 1;

            //Aqui creamos el arreglo de Arepas
            Arepa[] arregloArepas = new Arepa[cantidad];

            Random aleatorio = new Random();
            int tipoDeArepa=0, numeroMolino=0, diasCaducidad=0;

            //Inicializamos cada posición del arreglo de arepas
            //con una arepa de tipo aleatorio
            for (int i = 0; i < arregloArepas.Length; i++)
            {
                //0: Asada, 1: Congelada, 2: Procesada
                tipoDeArepa = aleatorio.Next(3);
                numeroMolino = aleatorio.Next(1, 8);
                diasCaducidad = aleatorio.Next(0, 31);

                switch (tipoDeArepa)
                {
                    case 0:
                        arregloArepas[i] = new ArepaAsada(
                            tiposMasa[aleatorio.Next(tiposMasa.Length)],
                            "Asada",
                            diasCaducidad,
                            numeroMolino,
                            aleatorio.Next(20, 101));
                        break;

                    case 1:
                        arregloArepas[i] = new ArepaCongelada(
                            tiposMasa[aleatorio.Next(tiposMasa.Length)],
                            "Congelada",
                            diasCaducidad,
                            numeroMolino,
                            aleatorio.Next(30, 91));
                        break;

                    case 2:
                        arregloArepas[i] = new ArepaProcesada(
                            tiposMasa[aleatorio.Next(tiposMasa.Length)],
                            "Procesada",
                            diasCaducidad,
                            numeroMolino,
                            aleatorio.Next(30, 91),
                            aleatorio.Next(20, 101));
                        break;
                }
            }

            return arregloArepas;            
        }

        private string[] AsignaTiposMasa()
        {
            string[] arregloMasas = {
            "Chocolo",
            "Maiz",
            "Arroz",
            "Yuca",
            "Quinua"
            };

            return arregloMasas;
        }

        /// <summary>
        /// Obtiene el arreglo de arepas
        /// </summary>
        /// <returns>Las Arepas</returns>
        public Arepa[] GetLasArepas()
        {
            return lasArepas;
        }


        public int ObtieneArepasVencidas()
        {
            int contadorArepasVencidas=0;

            foreach (Arepa unaArepa in lasArepas)
            {
                if (unaArepa.GetDiasCaducidad() == 0)
                    contadorArepasVencidas++;
            }
            return contadorArepasVencidas;
        }
    }
}
