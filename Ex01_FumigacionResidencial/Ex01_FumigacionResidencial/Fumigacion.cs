using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_FumigacionResidencial
{
    public class Fumigacion
    {
        protected string plaga;
        protected string metodoFumigacion;

        public Fumigacion()
        {
            plaga = string.Empty;
            metodoFumigacion = string.Empty;
        }

        public Fumigacion(string plaga, string metodoFumigacion)
        {
            this.plaga = plaga;
            this.metodoFumigacion = metodoFumigacion;
        }

        public string GetPlaga()
        {
            return plaga;
        }

        public void SetPlaga(string plaga)
        {
            this.plaga = plaga;
        }

        public string GetMetodoFumigacion()
        {
            return metodoFumigacion;
        }

        public void SetMetodoFumigacion(string metodoFumigacion)
        {
            this.metodoFumigacion = metodoFumigacion;
        }

        public override string ToString()
        {
            string informacion = $"Se fumigó para {plaga} usando {metodoFumigacion}";
            return informacion;
        }
    }
}
