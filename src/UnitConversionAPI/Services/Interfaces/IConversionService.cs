using UnitConversionAPI.DTOs;

namespace UnitConversionAPI.Services.Interfaces
{
    public interface IConversionService
    {
        ConversionResponse Convert(ConversionRequest request);
    }
}
