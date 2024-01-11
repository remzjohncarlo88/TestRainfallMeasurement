﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TestRainfallMeasurement.Models;

namespace TestRainfallMeasurement.Controllers
{
    /// <summary>
    /// Rainfall Controller
    /// </summary>
    [ApiController]
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
        /// <param name="requestModel">contains parameter and limit</param>
        /// <returns>List of rainfall measurements</returns>
        [HttpGet, Route("flood-monitoring/data/readings")]
        [Produces("application/json")]
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

