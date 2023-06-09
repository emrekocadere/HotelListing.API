using HotelListing.API;
using HotelListing.API.Data;
using HotelListing.API.Repository;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("HotelListingDbConnectionString");
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HotelListingDbContext>(options => { options.UseSqlServer(connectionString); });
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICountriesRepository, CountriesRepository>();

builder.Services.AddCors(options=>options.AddPolicy("AllowAll",
     b=>b.AllowAnyHeader().AllowAnyOrigin().AllowAnyOrigin()));

builder.Host.UseSerilog((ctx,lc)=>lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));



builder.Services.AddAutoMapper(typeof(MapperConfig).Assembly);

var app = builder.Build(); 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSerilogRequestLogging();

app.MapControllers();

app.UseCors("AllowAll");

app.Run();
