using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TestRainfallMeasurement.Models;

namespace TestRainfallMeasurement.Controllers
{
    /// <summary>
    /// Rainfall Controller
    /// </summary>
    [ApiController]
    [EnableCors("AllowCors")]
    public class RainfallController : ControllerBase
    {
        private readonly RainfallContext _rainfallContext;
        
       /// <summary>
       /// Rainfall controller
       /// </summary>
       /// <param name="context">rainfall context</param>
        public RainfallController(RainfallContext context)
        {
            _rainfallContext = context;
        }

        // https://environment.data.gov.uk/flood-monitoring/data/readings?parameter=rainfall&_limit=100
        /// <summary>
        /// Get the list of rainfall measurements
        /// </summary>
        /// <returns>Rainfall list</returns>
        [HttpGet, Route("flood-monitoring/data/readings")]
        [EnableCors]
        [ProducesResponseType<RainModel>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<RainModel> GetAll(
            [FromQuery] RequestModel requestModel)
        {
            var r = _rainfallContext.Rains.FirstOrDefault();
            return _rainfallContext.Rains.First();
        }
    }
}

