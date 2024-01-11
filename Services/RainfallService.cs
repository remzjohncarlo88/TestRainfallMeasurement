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
        /// <param name="id">rain id</param>
        /// <returns>Rainfall list</returns>
        public List<RainItemModel> GetRainfallById(string id)
        {
            List<RainItemModel> rainItems = _rainfallRepository.GetRainfallById(id).Result.ToList();

            return rainItems;
        }
    }
}
