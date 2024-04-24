using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Nota_Final
{
    internal class Aluno
    {
        public string Nome;
        public double NotaTrimestre1, NotaTrimestre2, NotaTrimestre3;

        public double CalculaNotaFinal()
        {
            return NotaTrimestre1 + NotaTrimestre2 + NotaTrimestre3;
        }

        public string VerificaAprovacao(double notaFinal)
        {
            string resultado;

            if (notaFinal >= 60)
            {
                resultado = "Aprovado";
            }
            else
            {
                resultado = "Reprovado";
            }

            return resultado;
        }
    }
}