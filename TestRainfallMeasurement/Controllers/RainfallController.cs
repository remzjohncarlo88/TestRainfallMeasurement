using Microsoft.AspNetCore.Mvc;
using TestRainfallMeasurement.Models;
using TestRainfallMeasurement.Services;

namespace TestRainfallMeasurement.Controllers
{
    /// <summary>
    /// Rainfall Controller
    /// </summary>
    [ApiController]
    public class RainfallController : ControllerBase
    {
        private readonly IRainfallService _rainfallService;

        /// <summary>
        /// Rainfall controller
        /// </summary>
        /// <param name="rainfallService">rainfall service object</param>
        public RainfallController(IRainfallService rainfallService)
        {
            _rainfallService = rainfallService;
        }

        /// <summary>
        /// Get the list of rainfall measurements
        /// </summary>
        /// <param name="request">rain id and limit per request</param>
        /// <returns>RainItem list</returns>
        [HttpGet("GetRainfallById")]
        [Produces("application/json")]
        [ProducesResponseType<RainItemModel>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetRainfallById(string i)
        {
            RequestModel request = new RequestModel();
            request.Id = "52203-rainfall-tipping_bucket_raingauge-t-15_min-mm";
            request.Limit = 10;
            var rainfallList = _rainfallService.GetRainfallById(request);

            if (rainfallList == null)
                return NotFound();

            return Ok(rainfallList);
        }
    }
}

