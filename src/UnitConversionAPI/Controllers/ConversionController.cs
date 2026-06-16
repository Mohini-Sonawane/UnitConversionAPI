using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitConversionAPI.DTOs;
using UnitConversionAPI.Services.Interfaces;

namespace UnitConversionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _service;
        public ConversionController(IConversionService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Convert(ConversionRequest request)
        {
            return Ok(_service.Convert(request));
        }
    }
}
