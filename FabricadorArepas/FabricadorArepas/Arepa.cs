using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    public abstract class Arepa
    {
        protected string tipoDeMasa, tipoArepa;
        protected int diasCaducidad, numeroMolino;

        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public Arepa()
        {
            tipoArepa = "";
            tipoDeMasa = "";
            diasCaducidad = 0;
            numeroMolino = 0;
        }

        /// <summary>
        /// Constructor con parámetros específicos
        /// </summary>
        /// <param name="tipoDeMasa">La masa</param>
        /// <param name="tipoArepa">El tipo</param>
        /// <param name="diasCaducidad">Los días</param>
        /// <param name="numeroMolino">El molino</param>
        public Arepa(string tipoDeMasa, string tipoArepa, int diasCaducidad, int numeroMolino)
        {
            this.tipoArepa = tipoArepa;
            this.tipoDeMasa= tipoDeMasa;
            this.diasCaducidad = diasCaducidad;
            this.numeroMolino = numeroMolino;
        }

        public string GetTipoDeMasa()
        {
            return tipoDeMasa;
        }

        public void SetTipoDeMasa(string tipoDeMasa)
        {
            this.tipoDeMasa = tipoDeMasa;
        }

        public string GetTipoArepa()
        {
            return tipoArepa;
        }

        public void SetTipoArepa(string tipoArepa)
        {
            this.tipoArepa = tipoArepa;
        }

        public int GetDiasCaducidad()
        {
            return diasCaducidad;
        }

        public void SetDiasCaducidad(int diasCaducidad)
        {
            if (diasCaducidad > 0)
                this.diasCaducidad = diasCaducidad;
            else
                this.diasCaducidad = 0;
        }

        public int GetNumeroMolino()
        {
            return numeroMolino;
        }

        public void SetNumeroMolino(int numeroMolino)
        {
            this.numeroMolino = numeroMolino;
        }

        public abstract string ObtieneInformacion();
    }
}
