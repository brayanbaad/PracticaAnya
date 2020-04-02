using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class LiquidacionRegimenContributivo : LiquidacionCoutaModeradora
    {
        public override double RecibirTarifa()
        {
            if (SalarioDevengado < 1775606)
            {
                return 15;
            }
            else
               if (SalarioDevengado >= 1775606 && SalarioDevengado < 4439015)
            {
                return 20;
            }
            else
            {
                return 25;
            }
        }

        public override double RecibirTope()
        {
            if (SalarioDevengado < 1775606)
            {
                return 250000;
            }
            else if (SalarioDevengado >= 1775606 && SalarioDevengado < 4439015)
            {
                return 900000;
            }
            else
            {
                return 15000000;
            }
        }
    }
}
