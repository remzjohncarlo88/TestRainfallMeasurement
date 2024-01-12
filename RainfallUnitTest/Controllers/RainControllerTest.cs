using Microsoft.AspNetCore.Mvc;
using RainfallUnitTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRainfallMeasurement.Controllers;
using TestRainfallMeasurement.Models;
using TestRainfallMeasurement.Services;

namespace RainfallUnitTest.Controllers
{
    public class RainControllerTest
    {
        private readonly RainfallController _controller;
        private readonly IRainfallService _service;

        /// <summary>
        /// FID Contoller Test
        /// </summary>
        public RainControllerTest()
        {
            _service = new RainServiceTest();
            _controller = new RainfallController(_service);
        }

        [Fact]
        public void GetDelayedFlights_WhenCalled_ReturnsRightItem()
        {
            RequestModel requestModel = new RequestModel();
            requestModel.Limit = 2;
            // Act
            var items = _controller.GetRainfallById("") as OkObjectResult;
            // Assert
            var itemsEq = Assert.IsType<List<RainItemModel>>(items.Value);
            Assert.Equal(2, itemsEq.Count);
        }
    }
}
