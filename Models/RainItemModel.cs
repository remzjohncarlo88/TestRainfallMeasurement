using System.ComponentModel;
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
        [JsonPropertyName("@id"), DisplayName("Id")]
        public string? Id { get; set; }
        DateTime _date;
        /// <summary>
        /// Date
        /// </summary>
        [JsonPropertyName("DateTime")]
        public DateTime DateTime
        {
            get { return _date; }
            set { _date = Convert.ToDateTime(value); }
        }
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
