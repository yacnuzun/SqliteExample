using Business.Abstract;
using Business.Concrete;
using DataAccess.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EfConcrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DataAccess.Concrete.DatabaseContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EntegraDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("EntegraDbContext"));
});
builder.Services.AddSingleton<IProductDal, EfProductDal>();
builder.Services.AddSingleton<IProductService, ProductManager>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
