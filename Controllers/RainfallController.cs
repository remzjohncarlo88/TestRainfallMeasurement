using Microsoft.AspNetCore.Mvc;
using TestRainfallMeasurement.Models;

namespace TestRainfallMeasurement.Controllers
{
    /// <summary>
    /// Rainfall Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
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

        /// <summary>
        /// Get the list of rainfall measurements
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAllRainfall")]
        public ActionResult<RainModel> GetAll()
        {
            return _rainfallContext.Rains.First();
        }
    }
}
