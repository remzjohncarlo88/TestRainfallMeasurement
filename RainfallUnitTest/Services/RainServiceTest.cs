using TestRainfallMeasurement.Models;
using TestRainfallMeasurement.Services;

namespace RainfallUnitTest.Services
{
    public class RainServiceTest : IRainfallService
    {
        private readonly List<RainItemModel> _rainItems;
        public RainServiceTest()
        {
            _rainItems = new List<RainItemModel>()
            {
                new RainItemModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/52203-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-01-11T12-00-00Z" ,
                        Date = Convert.ToDateTime("2024-01-11T12:00:00Z") ,
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/52203-rainfall-tipping_bucket_raingauge-t-15_min-mm" ,
                        Value = 0 },
                new RainItemModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/52203-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-01-11T11-45-00Z" ,
                        Date = Convert.ToDateTime("2024-01-11T11:45:00Z") ,
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/52203-rainfall-tipping_bucket_raingauge-t-15_min-mm" ,
                        Value = 0 }
            };
        }

        /// <summary>
        /// GetRainfallById
        /// </summary>
        /// <param name="request">rainfall params</param>
        /// <returns>Rainfall list</returns>
        public List<RainItemModel> GetRainfallById(RequestModel request)
        {
            return _rainItems.Take(request.Limit).ToList();
        }
    }
}
