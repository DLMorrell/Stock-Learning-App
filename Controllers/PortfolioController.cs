using Alpaca.Markets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stock_Learning_App.API;
using Stock_Learning_App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock_Learning_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly ILogger<PortfolioController> _logger;

        public PortfolioController(ILogger<PortfolioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public PortfolioModel Get()
        {
            AccountAPI account = new AccountAPI();
            Task<IReadOnlyList<IPosition>> positions = PortfolioAPI.accessPositions();

            return new PortfolioModel()
            {
                BuyingPower = account.getBuyingPower(),
                Positions = positions.Result
            };
        }
    }
}
