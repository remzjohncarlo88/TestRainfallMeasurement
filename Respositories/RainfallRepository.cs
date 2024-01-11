using Newtonsoft.Json;
using TestRainfallMeasurement.Models;

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
        /// <param name="request">rainfall params</param>
        /// <returns>list of rainfallk measurements</returns>
        public async Task<IEnumerable<RainItemModel>> GetRainfallById(RequestModel request)
        {
            RainModel rainfallList = new RainModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(string.Concat("http://environment.data.gov.uk/flood-monitoring/id/measures/", request.Id, "/readings?_sorted&_limit=", request.Limit)))
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
