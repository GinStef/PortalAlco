using Microsoft.EntityFrameworkCore;
using portal.bdpossuc;
using portal.Reportes.TotalVenta;
using portal.Reportes.UnidadOperativa;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<BdpossucContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("bdpos"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.RegistraReporte();
app.RegistrarUnidadOperativa();
 
app.Run();
 