using Microsoft.EntityFrameworkCore;
using UserInsuranceDetails.WebApi.DAL.DatabaseContext;
using UserInsuranceDetails.WebApi.DAL.Repositories.Implementations;
using UserInsuranceDetails.WebApi.DAL.Repositories.Interfaces;
using UserInsuranceDetails.WebApi.Services.Mapper;
using UserInsuranceDetails.WebApi.Services.XmlToJsonService.Implementation;
using UserInsuranceDetails.WebApi.Services.XmlToJsonService.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IXmlDataRepository, XmlDataRepository>();
builder.Services.AddTransient<IXmlToJsonService, XmlToJsonService>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddDbContext<XmlDataDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
