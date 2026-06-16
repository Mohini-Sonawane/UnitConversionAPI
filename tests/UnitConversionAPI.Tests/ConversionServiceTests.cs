using UnitConversionAPI.DTOs;
using UnitConversionAPI.Services;

namespace UnitConversionAPI.Tests;

public class ConversionServiceTests
{
    private readonly ConversionService _service = new();
    [Fact]
    public void MeterToFoot()
    {
        var result = _service.Convert(new ConversionRequest
        {
            From="meter",
            To="foot",
            Value=1
        });

        Assert.Equal(3.2808,result.ConvertedValue,4);
    }
}
