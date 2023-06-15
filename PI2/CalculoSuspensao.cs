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

            double resultado_em_kg_mm, resultado_em_N_m;

            resultado_em_kg_mm = (f * bd) / sd;
            resultado_em_N_m = resultado_em_kg_mm * 10 * 1000;

            return resultado_em_N_m;
        }

        public static double CalcularCursoAngular(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não dá pra dividir por 0.");
            }

            double resultado, sine;

            sine = Math.Asin(a / b);

            resultado = 2 * sine;

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
