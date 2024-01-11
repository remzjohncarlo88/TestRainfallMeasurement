using Newtonsoft.Json;
using System.Net.Http.Headers;
using TestRainfallMeasurement.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TestRainfallMeasurement.Respositories
{
    /// <summary>
    /// Rainfall Repository
    /// </summary>
    public class RainfallRepository : IRainfallRepository
    {
        /// <summary>
        /// GetRainfallById
        /// </summary>
        /// <param name="id">rainfall id</param>
        /// <returns>list of rainfallk measurements</returns>
        public async Task<IEnumerable<RainItemModel>> GetRainfallById(string id)
        {
            RainModel rainfallList = new RainModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(string.Concat("http://environment.data.gov.uk/flood-monitoring/id/measures/", id, "/readings")))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        rainfallList = JsonConvert.DeserializeObject<RainModel>(apiResponse);
                    }
                }
            }

            return rainfallList.Items;
        }
    }
}
