using UnitConversionAPI.Middleware;
using UnitConversionAPI.Services;
using UnitConversionAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IConversionService, ConversionService>();


//builder.Services.AddOpenApi();


var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
if (app.Environment.IsDevelopment())
{
  // app.MapOpenApi();   
}
app.MapControllers();
app.UseHttpsRedirection();
app.Run();


