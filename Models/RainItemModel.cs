namespace TestRainfallMeasurement.Models
{
    /// <summary>
    /// Iterates the rain measurement
    /// </summary>
    public class RainItemModel
    {
        /// <summary>
        /// Date
        /// </summary>
        public DateTime DateTime { get; set; }
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
