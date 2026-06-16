using System.ComponentModel.DataAnnotations;

namespace UnitConversionAPI.DTOs
{
    public class ConversionRequest
    {
        [Required]
        public string From { get; set; } = "";

        [Required]
        public string To { get; set; } = "";

        public double Value { get; set; }
    }
}
