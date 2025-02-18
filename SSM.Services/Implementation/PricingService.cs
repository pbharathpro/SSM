using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSM.Services.Interface;

namespace SSM.Services.Implementation
{
    public class PricingService : IPricingService
    {
        public decimal CalculatePrice(int durationMonths)
        {
            decimal monthlyRate = 100;
            return monthlyRate * durationMonths;
        }
    }

}
