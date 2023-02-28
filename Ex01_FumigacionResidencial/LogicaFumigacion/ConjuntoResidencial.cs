using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaFumigacion
{
    public class ConjuntoResidencial
    {
        private Hogar[] losHogares;
        private FumigacionDisponible[] fumigacionesAccesibles;

        public ConjuntoResidencial(int cantidadHogares)
        {
            fumigacionesAccesibles = InicializaFumigacionesAccesibles();
            losHogares = new Hogar[cantidadHogares];
            InicializaHogares();
        }

        public FumigacionDisponible[] GetFumigacionesAccesibles()
        {
            return fumigacionesAccesibles;
        }

        private FumigacionDisponible[] InicializaFumigacionesAccesibles()
        {
            FumigacionDisponible[] unasFumigaciones = new FumigacionDisponible[]
                {
                    new FumigacionDisponible("Roedores","Anticoagulantes"),
                    new FumigacionDisponible("Roedores","Neurotóxicos"),
                    new FumigacionDisponible("Roedores","Repelentes"),
                    new FumigacionDisponible("Hongos","Desinfectantes"),
                    new FumigacionDisponible("Hongos","Fungicidas"),
                    new FumigacionDisponible("Hongos","Inhibidores"),
                    new FumigacionDisponible("Insectos","Insecticidas"),
                    new FumigacionDisponible("Insectos","Repelentes"),
                    new FumigacionDisponible("Insectos","Desinfectantes")
        };

            return unasFumigaciones;
        }

        public Hogar[] GetLosHogares()
        {
            return losHogares;
        }

        public void SetLosHogares(Hogar[] arregloHogares)
        {
            losHogares = arregloHogares;
        }

        private void InicializaHogares()
        {
            //0: No hubo fumigacion, 1: Hubo Fumigacion
            int visitaFumigador = 0;
            Random aleatorio = new Random();

            for(int i=0;i<losHogares.Length;i++)
            {
                visitaFumigador = aleatorio.Next(2);

                if (visitaFumigador == 0)
                    losHogares[i] = new Hogar();
                else
                {
                    losHogares[i] = new Hogar(
                            fumigacionesAccesibles[
                                aleatorio.Next(
                                    fumigacionesAccesibles.Length
                                    )
                                ]
                                );
                }
            }

            //Aqui totalizamos las fumigaciones disponibles utilizadas
            TotalizaFumigacionesDisponibles();
        }

        private void TotalizaFumigacionesDisponibles()
        {
            foreach (Hogar unHogar in losHogares)
            {
                if (unHogar.GetEstaFumigado())
                {
                    for (int i = 0; i < fumigacionesAccesibles.Length; i++)
                    {
                        if (unHogar.GetAccionFumigacion() == fumigacionesAccesibles[i])
                            fumigacionesAccesibles[i].IncrementaCantidad();
                    }
                }
            }
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

        public List<FumigacionDisponible> ObtieneProductoPlagaMasUtilizado(FumigacionDisponible[] lasFumigacionesDispoibles)
        {
            List<FumigacionDisponible> fumigacionesMasUtilizadas 
                = new List<FumigacionDisponible>();

            int cantidadMayor = lasFumigacionesDispoibles[0].GetCantidad();
            int posicionMayor = 0;

            for (int i = 1; i < lasFumigacionesDispoibles.Length; i++)
                if (lasFumigacionesDispoibles[i].GetCantidad() > cantidadMayor)
                {
                    posicionMayor = i;
                    cantidadMayor = lasFumigacionesDispoibles[i].GetCantidad();
                }


            foreach (FumigacionDisponible unaFumigacion in lasFumigacionesDispoibles)

                if (unaFumigacion.GetCantidad() == cantidadMayor)
                    fumigacionesMasUtilizadas.Add(unaFumigacion);

            return fumigacionesMasUtilizadas;
        }

        public string ObtieneProductoPlagaMasUtilizado()
        {
            int cantidadMayor = fumigacionesAccesibles[0].GetCantidad();
            int posicionMayor = 0;
            int cuantosMayores = 0;

            for (int i = 1; i < fumigacionesAccesibles.Length; i++)
            {
                if (fumigacionesAccesibles[i].GetCantidad() > cantidadMayor)
                {
                    posicionMayor = i;
                    cantidadMayor = fumigacionesAccesibles[i].GetCantidad();
                }
            }

            string resultado = "";

            foreach (FumigacionDisponible unaFumigacion in fumigacionesAccesibles)
            {
                if (unaFumigacion.GetCantidad() == cantidadMayor)
                {
                    cuantosMayores++;
                    resultado += unaFumigacion.ToString() + "\n";
                }
            }
            resultado += $"En total fueron {cuantosMayores}";

            return resultado;
        }
    }
}
