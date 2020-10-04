using Alpaca.Markets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Learning_App.Models
{
    public class PortfolioModel
    {
        public decimal BuyingPower { get; set; }
        public IReadOnlyList<IPosition> Positions { get; set; }
    }
}
