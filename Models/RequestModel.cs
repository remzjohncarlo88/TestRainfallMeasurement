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
        [DisplayName("rainfall"), DefaultValue(true), Description("Rainfall Set")]
        public bool rainfall { get; set; }
        /// <summary>
        /// display count
        /// </summary>
        [DisplayName("_limit"), MinLength(1), MaxLength(100), Required, Description("The number of readings to return")]
        public int limit { get; set; }
    }
}
