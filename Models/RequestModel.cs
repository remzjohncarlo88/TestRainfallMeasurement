using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestRainfallMeasurement.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// rainfall detection
        /// </summary>
        [DefaultValue("rainfall"), Description("Rainfall Set")]
        public string? parameter { get; set; }
        /// <summary>
        /// display count
        /// </summary>
        [DefaultValue(10), MinLength(1), MaxLength(100), Required, Description("The number of readings to return")]
        public int _limit { get; set; }
    }
}
