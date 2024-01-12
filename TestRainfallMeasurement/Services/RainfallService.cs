using TestRainfallMeasurement.Models;
using TestRainfallMeasurement.Respositories;

namespace TestRainfallMeasurement.Services
{
    /// <summary>
    /// Rainfall Service class
    /// </summary>
    public class RainfallService : IRainfallService
    {
        private readonly IRainfallRepository _rainfallRepository;

        /// <summary>
        /// RainfallService constructor
        /// </summary>
        /// <param name="rainfallRepository">interface rainfallRepository object</param>
        public RainfallService(IRainfallRepository rainfallRepository)
        {
            _rainfallRepository = rainfallRepository;
        }
        /// <summary>
        /// GetRainfallById
        /// </summary>
        /// <param name="request">rainfall params</param>
        /// <returns>Rainfall list</returns>
        public List<RainItemModel> GetRainfallById(RequestModel request)
        {
            List<RainItemModel> rainItems = _rainfallRepository.GetRainfallById(request).Result.ToList();

            return rainItems;
        }
    }
}
