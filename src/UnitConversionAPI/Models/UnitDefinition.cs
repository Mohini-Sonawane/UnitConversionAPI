namespace UnitConversionAPI.Models
{
    public class UnitDefinition
    {
        public string Name { get; set; } = string.Empty;

        public ConversionCategory Category { get; set; }

        public Func<double, double> ToBase { get; set; } = default!;

        public Func<double, double> FromBase { get; set; } = default!;
    }
}
