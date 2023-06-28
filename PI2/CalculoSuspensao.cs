using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI2
{
    public static class CalculoSuspensao
    {
        public static double CalcularConstanteElastica(double f, double bd, double sd)
        {
            if (sd == 0)
            {
                throw new DivideByZeroException("Não dá pra dividir por 0.");
            }

            double f_N, bd_m, sd_m, resultado;

            f_N = f * 9.81;
            bd_m = bd / 1000;
            sd_m = sd / 1000;

            resultado = (f_N * bd_m) / sd_m;

            return resultado;
        }

        public static double CalcularCursoAngular(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não dá pra dividir por 0.");
            }

            double resultado;

            resultado = 2 * Math.Asin(a / b);

            resultado = RadianosParaGraus(resultado);

            return resultado;
        }

        public static double RadianosParaGraus(double a)
        {
            double resultado;

            resultado = a * 180 / Math.PI;

            return resultado;
        }

        public static double GrausParaRadianos(double a)
        {
            double resultado;

            resultado = a * Math.PI / 180;

            return resultado;
        }
    }
}
