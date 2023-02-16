using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_FumigacionResidencial
{
    public class ConjuntoResidencial
    {
        private Hogar[] losHogares;

        public ConjuntoResidencial(int cantidadHogares)
        {
            losHogares = new Hogar[cantidadHogares];
            InicializaHogares();
        }

        public Hogar[] GetLosHogares()
        {
            return losHogares;
        }

        private void InicializaHogares()
        {
            //0: No hubo fumigacion, 1: Hubo Fumigacion
            int visitaFumigador = 0;

            //0: Roedores, 1: Insectos; 2: Hongos
            int plagaIdentificada = 0;
            Fumigacion accionFumigacion = new Fumigacion();

            Random aleatorio = new Random();

            for(int i=0;i<losHogares.Length;i++)
            {
                visitaFumigador = aleatorio.Next(2);

                if (visitaFumigador == 0)
                    losHogares[i] = new Hogar();
                else
                {
                    plagaIdentificada = aleatorio.Next(3);

                    switch (plagaIdentificada)
                    {
                        //Rodedores
                        case 0:
                            accionFumigacion = ObtieneAccionFumigacion("Roedores");
                            break;

                        //Insectos
                        case 1:
                            accionFumigacion = ObtieneAccionFumigacion("Insectos");
                            break;

                        //Hongos
                        case 2:
                            accionFumigacion = ObtieneAccionFumigacion("Hongos");
                            break;
                    }

                    losHogares[i] = new Hogar(accionFumigacion);
                }
            }
        }

        private Fumigacion ObtieneAccionFumigacion(string plaga)
        {
            Fumigacion fumigacionSeleccionada = new Fumigacion();
            Random aleatorio = new Random();
            string metodoFumigacion = "";
            int metodoSeleccionado = 0;

            if (plaga == "Roedores")
            {
                metodoSeleccionado = aleatorio.Next(3);
                switch (metodoSeleccionado)
                {
                    case 0:
                        metodoFumigacion = "Anticoagulantes";
                        break;

                    case 1:
                        metodoFumigacion = "Neurotóxicos";
                        break;

                    case 2:
                        metodoFumigacion = "Repelentes";
                        break;
                }
            }


            if (plaga == "Insectos")
            {
                metodoSeleccionado = aleatorio.Next(3);
                switch (metodoSeleccionado)
                {
                    case 0:
                        metodoFumigacion = "Insecticidas";
                        break;

                    case 1:
                        metodoFumigacion = "Repelentes";
                        break;

                    case 2:
                        metodoFumigacion = "Desinfectantes";
                        break;
                }
            }

            if (plaga == "Hongos")
            {
                metodoSeleccionado = aleatorio.Next(3);
                switch (metodoSeleccionado)
                {
                    case 0:
                        metodoFumigacion = "Desinfectantes";
                        break;

                    case 1:
                        metodoFumigacion = "Fungicidas";
                        break;

                    case 2:
                        metodoFumigacion = "Inhibidores";
                        break;
                }
            }

            fumigacionSeleccionada = new Fumigacion(plaga, metodoFumigacion);

            return fumigacionSeleccionada;
        }

        public double ObtienePorcentajeHogaresFumigados()
        {
            double porcentaje = 0;

            foreach (Hogar unHogar in losHogares)
            {
                if (unHogar.GetEstaFumigado())
                    porcentaje++;
            }

            return ((porcentaje/losHogares.Length)*100);
        }
    }
}
