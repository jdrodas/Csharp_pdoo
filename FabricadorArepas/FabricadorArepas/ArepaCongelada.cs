using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    public class ArepaCongelada: Arepa, ICongelable
    {
        private int diasMaximosCongelado;

        public ArepaCongelada(): base()
        {
            diasMaximosCongelado = 0;
        }

        public ArepaCongelada(string tipoDeMasa, string tipoArepa,
                              int diasCaducidad, int numeroMolino, int diasMaximosCongelado)
            :base(tipoDeMasa,tipoArepa,diasCaducidad,numeroMolino)
        {
            this.diasMaximosCongelado= diasMaximosCongelado;        
        }

        public int GetDiasMaximosCongelado()
        {
            return diasMaximosCongelado;
        }

        public void SetDiasMaximosCongelado(int diasMaximosCongelado)
        {
            if (diasMaximosCongelado > 0)
                this.diasMaximosCongelado = diasMaximosCongelado;
            else
                this.diasMaximosCongelado = 0;
        }

        public string InfoCongelacion()
        {
            string info = $"Días máximos de congelación: {diasMaximosCongelado}";
            return info;
        }

        public override string ObtieneInformacion()
        {
            string informacion = $"Esta es una arepa {tipoArepa}. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del molino {numeroMolino} \n" +
                $"Días de caducidad: {diasCaducidad} \n" +
                InfoCongelacion();
            return informacion;
        }
    }
}
