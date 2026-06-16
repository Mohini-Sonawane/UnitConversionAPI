namespace UnitConversionAPI.DTOs
{
    public class ConversionResponse
    {
        public double OriginalValue { get; set; }

        public string From { get; set; } = "";

        public string To { get; set; } = "";

        public double ConvertedValue { get; set; }
    }
}
