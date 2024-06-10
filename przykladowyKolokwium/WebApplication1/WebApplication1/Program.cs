using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Repositories;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IMuzykService, MuzykService>();
builder.Services.AddScoped<IMuzykRepository, MuzykRepository>();

builder.Services.AddDbContext<MusicDbContext>(opt =>
{
    string connString = builder.Configuration.GetConnectionString("DeffaultConnection");
    opt.UseSqlServer(connString);
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();


app.Run();


//db-mssql16.pjwstk.edu.pl
//sqllocaldb create "myLocalBase"


//dotnet new tool-manifest
//dotnet tool install dotnet-ef
//dotnet ef migrations add Init
//dotnet ef database update