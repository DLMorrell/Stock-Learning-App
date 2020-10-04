using Alpaca.Markets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stock_Learning_App.API;
using System.Collections.Generic;

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
        public IReadOnlyList<IPosition> Get()
        {
            var positions = PortfolioAPI.accessPositions();
            return positions.Result;
        }
    }
}
