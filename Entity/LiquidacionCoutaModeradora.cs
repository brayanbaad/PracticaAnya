using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public  abstract class LiquidacionCoutaModeradora
    {
        public string TipoAfiliacion { get; set; }
        public string IdPaciente { get; set; }
        public string NumeroLiquidacion { get; set; }
        public double SalarioDevengado { get; set; }
        public double ValorServicio { get; set; }
        public double Tarifa { get; set; }
        public double CoutaModerada { get; set; }
        public double MaximoTope { get; set; }
        public double ValorReal { get; set; }

        public abstract double RecibirTope();
        public abstract double RecibirTarifa();


        public double CalcularCuotaModerada()
        {
            Tarifa = RecibirTarifa();
            MaximoTope = RecibirTope();
            CoutaModerada = (ValorServicio * (Tarifa / 100)) + ValorServicio;
            ValorReal = CoutaModerada;
            if (CoutaModerada > MaximoTope)
            {
                CoutaModerada = MaximoTope;
            }
            return CoutaModerada;
        }

    }
}
