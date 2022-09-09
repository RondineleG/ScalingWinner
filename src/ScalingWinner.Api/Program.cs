using Microsoft.EntityFrameworkCore;
using ScalingWinner.Data.Context;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

builder.Services.AddControllers();
builder.Services.AddDbContext<ScalingWinnerDataContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                     b => b.MigrationsAssembly(typeof(ScalingWinnerDataContext).Assembly.FullName)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
