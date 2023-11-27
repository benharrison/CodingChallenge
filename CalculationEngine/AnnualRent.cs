using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationEngine;
public class AnnualRent
{
    public decimal? Calculate(decimal? monthlyRent)
    {
        if (monthlyRent == null || monthlyRent < 0)
            return null;

        return 12 * monthlyRent;
    }
}
