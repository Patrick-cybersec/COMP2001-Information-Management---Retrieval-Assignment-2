using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using ProfileService.Models;

var builder = WebApplication.CreateBuilder(args);

var server = Environment.GetEnvironmentVariable("DB_SERVER") ?? "DIST-6-505.uopnet.plymouth.ac.uk"; 
var database = Environment.GetEnvironmentVariable("DB_DATABASE") ?? "COMP2001_HK_PTang"; 
var userId = Environment.GetEnvironmentVariable("DB_USER") ?? "HK_PTang"; 
var password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "ZqjB951*";
var port = Environment.GetEnvironmentVariable("DB_PORT") ?? "3306";
var connectionString = $"server={server};port={port};database={database};user={userId};password={password};";
builder.Services.AddDbContext<ProfileDbContext>(options =>
    options.UseMySQL($"Server={server};Database={database};User Id={userId};Password={password};Connection Timeout=30;"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Profile Service API", Version = "v1" });
});

builder.Services.AddAuthorization();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Profile Service API v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();