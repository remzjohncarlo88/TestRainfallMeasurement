using System.Text.Json.Serialization;

namespace TestRainfallMeasurement.Models
{
    /// <summary>
    /// Iterates the rain measurement
    /// </summary>
    public class RainItemModel
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("@id")]
        public string? Id { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [JsonPropertyName("DateTime")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        public string? Measure { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        public decimal Value { get; set; }
    }
}
