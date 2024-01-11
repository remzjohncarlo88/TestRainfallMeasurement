using TestRainfallMeasurement.Models;

namespace TestRainfallMeasurement.Services
{
    /// <summary>
    /// Rainfall Interface Service
    /// </summary>
    public interface IRainfallService
    {
        /// <summary>
        /// GetRainfallById
        /// </summary>
        /// <param name="id">rain id</param>
        /// <returns>Rainfall list</returns>
        List<RainItemModel> GetRainfallById(string id);
    }
}
