using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI2
{
    public static class CalculoSuspensao
    {
        public static decimal CalcularConstanteElastica(decimal f, decimal bd, decimal sd)
        {
            decimal resultado;

            resultado = (f * bd) / sd;

            return resultado;
        }

        public static decimal CalcularCursoAngular(decimal a, decimal b)
        {
            decimal resultado;

            resultado = 2 * (a / 2) / b;

            return resultado;
        }

        public static decimal RadianosParaGraus(decimal a)
        {
            decimal resultado;

            resultado = a * 180 / Convert.ToDecimal(Math.PI);

            return resultado;
        }

        public static decimal GrausParaRadianos(decimal a)
        {
            decimal resultado;

            resultado = a * Convert.ToDecimal(Math.PI) / 180;

            return resultado;
        }
    }
}
