using UnitConversionAPI.Models;

namespace UnitConversionAPI.Data
{
    public static class UnitData
    {
        public static Dictionary<string, UnitDefinition> Units =>
        new(StringComparer.OrdinalIgnoreCase)
        {
            // Length (base = meter)

            ["meter"] = new()
            {
                Name="meter",
                Category=ConversionCategory.Length,
                ToBase=x=>x,
                FromBase=x=>x
            },
            ["foot"] = new()
            {
                Name="foot",
                Category=ConversionCategory.Length,
                ToBase=x=>x*0.3048,
                FromBase=x=>x/0.3048
            },
            ["kilometer"] = new()
            {
                Name="kilometer",
                Category=ConversionCategory.Length,
                ToBase=x=>x*1000,
                FromBase=x=>x/1000
            },
            // Weight (base=kg)

            ["kilogram"]=new()
            {
                Name="kilogram",
                Category=ConversionCategory.Weight,
                ToBase=x=>x,
                FromBase=x=>x
            },
            ["pound"]=new()
            {
                Name="pound",
                Category=ConversionCategory.Weight,
                ToBase=x=>x*0.453592,
                FromBase=x=>x/0.453592
            },

            // Temperature (base = Celsius)

            ["celsius"]=new()
            {
                Name="celsius",
                Category=ConversionCategory.Temperature,
                ToBase=x=>x,
                FromBase=x=>x
            },
            ["fahrenheit"]=new()
            {
                Name="fahrenheit",
                Category=ConversionCategory.Temperature,
                ToBase=x=>(x-32)*5/9,
                FromBase=x=>x*9/5+32
            }
        };
    }
}
