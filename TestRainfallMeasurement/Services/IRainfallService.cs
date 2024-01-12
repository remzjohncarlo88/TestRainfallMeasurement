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
        /// <param name="request">rainfall params</param>
        /// <returns>Rainfall list</returns>
        List<RainItemModel> GetRainfallById(RequestModel request);
    }
}
