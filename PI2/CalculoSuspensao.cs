using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI2
{
    public static class CalculoSuspensao
    {
        public static float CalcularConstanteElastica(float f, float bd, float sd)
        {
            if (sd == 0)
            {
                throw new DivideByZeroException("Não dá pra dividir por 0.");
            }

            float resultado_em_kg_mm, resultado_em_N_m;

            resultado_em_kg_mm = (f * bd) / sd;
            resultado_em_N_m = resultado_em_kg_mm * 10 * 1000;

            return resultado_em_N_m;
        }

        public static float CalcularCursoAngular(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não dá pra dividir por 0.");
            }

            float resultado;

            resultado = (float) (2 * Math.Asin(a / b));

            resultado = RadianosParaGraus(resultado);

            return resultado;
        }

        public static float RadianosParaGraus(float a)
        {
            float resultado;

            resultado = (float) (a * 180 / Math.PI);

            return resultado;
        }

        public static float GrausParaRadianos(float a)
        {
            float resultado;

            resultado = (float) (a * Math.PI / 180);

            return resultado;
        }
    }
}
