using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    class ArepaCongelada : Arepa, ICongelable
    {
        private int diasMaximosCongelado;

        public ArepaCongelada(): base()
        {
            diasMaximosCongelado = 0;
        }

        public ArepaCongelada(string tipoDeMasa,
                              int diasCaducidad,
                              int numeroMolino,
                              int diasMaximosCongelado) : base(
                                  tipoDeMasa, diasCaducidad, numeroMolino)
        {
            this.diasMaximosCongelado = diasMaximosCongelado;
        }

        public int DiasMaximosCongelado
        {
            get { return diasMaximosCongelado; }
            set { diasMaximosCongelado = value; }
        }

        public string InfoCongelacion()
        {
            string info = $"Dias maximos de congelacion: {diasMaximosCongelado}";
            return info; ;
        }

        public override string ObtieneInformacion()
        {
            string info = "Esta arepa fue congelada. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del molino {numeroMolino} \n" +
                $"Dias caducidad: {diasCaducidad}" +
                InfoCongelacion();
            return info;
        }
    }
}
