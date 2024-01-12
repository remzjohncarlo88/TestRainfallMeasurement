using TestRainfallMeasurement.Models;

namespace TestRainfallMeasurement.Respositories
{
    /// <summary>
    /// Rainfall Repository Interface
    /// </summary>
    public interface IRainfallRepository
    {
        /// <summary>
        /// GetRainfallById
        /// </summary>
        /// <param name="request">rainfall params</param>
        /// <returns></returns>
        Task<IEnumerable<RainItemModel>> GetRainfallById(RequestModel request);
    }
}
