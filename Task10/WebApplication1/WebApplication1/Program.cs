using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Entities;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


builder.Services.AddDbContext<HospitalDbContext>(opt =>
{
    string connString = builder.Configuration.GetConnectionString("DeffaultConnection");
    opt.UseSqlServer(connString);
});



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();


app.Run();