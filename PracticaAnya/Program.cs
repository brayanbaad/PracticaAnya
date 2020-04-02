using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace PracticaAnya
{
    class Program
    {

        static void Main(string[] args)
        {
            LiquidacionCoutaModeradora liquidacion;
            string numeroLiquidacion, idPaciente, tipo;

            Console.Write("Digite numero de liquidacion :");
            numeroLiquidacion = Console.ReadLine();
            Console.Write("Digite identificacion del paciente:");
            idPaciente = Console.ReadLine();
            Console.Write("Digite tipo de afiliacion contributivo / subsidiado :");
            tipo = Console.ReadLine();
            if (tipo.Equals("contributivo"))
            {
                liquidacion = new LiquidacionRegimenContributivo();
                Console.Write("Digite salario devengado por el paciente: ");
                liquidacion.SalarioDevengado = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                liquidacion = new LiquidacionRegimenSubsidiado();
            }
            Console.Write("Digite valor  del servicio hospitalizacion prestado:");
            liquidacion.ValorServicio = Convert.ToDouble(Console.ReadLine());
            liquidacion.IdPaciente = idPaciente;
            liquidacion.NumeroLiquidacion = numeroLiquidacion;
            liquidacion.TipoAfiliacion = tipo;
            double resultado = liquidacion.CalcularCuotaModerada();

            Console.Clear();

            Console.WriteLine($"Numero de liquidacion :{liquidacion.NumeroLiquidacion}\n"
                + $" Numero de identificacion:{liquidacion.IdPaciente}\n" +
                $" Tipo afiliacion :{liquidacion.TipoAfiliacion}\n" +
                $"Salario Devengado:{liquidacion.SalarioDevengado}\n" +
                $"Valor del servicio : {liquidacion.ValorServicio}\n"
                + $"Tarifa:{liquidacion.Tarifa}\n" +
                $"Tope maximo:{liquidacion.MaximoTope}\n"
                + $"Couta Moderadora real:{liquidacion.ValorReal}\n" +
                $"cuota moderadora  calculada:{resultado}");

            Console.ReadKey();

        
    }
    }
}
