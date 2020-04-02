using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionRegimenSubsidiado : LiquidacionCoutaModeradora
    {
        public LiquidacionRegimenSubsidiado()
        {
            SalarioDevengado = 0;
        }
        public override double RecibirTarifa()
        {
            return 5;
        }

        public override double RecibirTope()
        {
            return 200000;
        }
    }
}
