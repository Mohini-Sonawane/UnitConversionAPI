using UnitConversionAPI.Data;
using UnitConversionAPI.DTOs;
using UnitConversionAPI.Services.Interfaces;

namespace UnitConversionAPI.Services
{
    public class ConversionService : IConversionService
    {
        public ConversionResponse Convert(ConversionRequest request)
        {
            if (!UnitData.Units.TryGetValue(request.From, out var from))
                throw new Exception("Invalid source unit.");

            if (!UnitData.Units.TryGetValue(request.To, out var to))
                throw new Exception("Invalid target unit.");

            if (from.Category != to.Category)
                throw new Exception("Units belong to different categories.");

            var baseValue = from.ToBase(request.Value);

            var converted = to.FromBase(baseValue);

            return new ConversionResponse
            {
                OriginalValue = request.Value,
                From = request.From,
                To = request.To,
                ConvertedValue = Math.Round(converted, 4)
            };
        }
    }
}
