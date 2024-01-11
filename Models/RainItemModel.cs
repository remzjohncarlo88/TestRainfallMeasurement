using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TestRainfallMeasurement.Models
{
    /// <summary>
    /// Iterates the rain measurement
    /// </summary>
    [DataContract]
    public class RainItemModel
    {
        /// <summary>
        /// Id
        /// </summary>
        [DataMember(Name = "@id")]
        public string? Id { get; set; }
        DateTime _date;
        /// <summary>
        /// Date
        /// </summary>
        [DataMember(Name = "dateTime")]
        public DateTime Date
        {
            get { return _date; }
            set { _date = Convert.ToDateTime(value); }
        }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember(Name = "measure")]
        public string? Measure { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        [DataMember(Name = "value")]
        public decimal Value { get; set; }
    }
}
