using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestRainfallMeasurement.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// rainfall id
        /// </summary>
        [Description("Rainfall Id")]
        public string? Id { get; set; }
        /// <summary>
        /// display count
        /// </summary>
        [DefaultValue(10), MinLength(1), MaxLength(100), Required, Description("The number of readings to return")]
        public int Limit { get; set; }
    }
}
