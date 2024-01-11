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
        /// <param name="id">rainfall id</param>
        /// <returns></returns>
        Task<IEnumerable<RainItemModel>> GetRainfallById(string id);
    }
}
