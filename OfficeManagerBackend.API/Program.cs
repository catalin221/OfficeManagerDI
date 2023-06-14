using OfficeManagerBackend.Domain.Entities;
using OfficeManagerBackend.Application.Abstract;
using OfficeManagerBackend.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICommunicationService, CommunicationService>();
builder.Services.AddScoped<OfficeManager>();

builder.Services.AddAuthorization();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
