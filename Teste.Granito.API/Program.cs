using Microsoft.EntityFrameworkCore;
using Teste.Granito.Domain.Interfaces;
using Teste.Granito.Domain.Interfaces.Services;
using Teste.Granito.Repository;
using Teste.Granito.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITaxaJurosService, TaxaJurosServices>()
    .AddScoped<ITaxaJurosRepository, TaxaJurosRepository>()
    .AddDbContext<DataBaseContext>(opt => opt.UseInMemoryDatabase("taxas"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var serviceProvider = builder.Services.BuildServiceProvider();
var taxaJurosServices = serviceProvider.GetService<ITaxaJurosService>();
taxaJurosServices.Criar(0.01);

app.Run();
