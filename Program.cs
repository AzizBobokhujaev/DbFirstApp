using DbFirstApp.DBContext;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
var connectionStrings = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AlifShopContext>(x =>
    x.UseMySql(connectionStrings, ServerVersion.AutoDetect(connectionStrings)).UseLazyLoadingProxies());
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