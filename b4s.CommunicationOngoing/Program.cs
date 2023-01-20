using b4s.CommunicationOngoing.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<B4sDbContext>
    (options => options.UseMySql(
        "server=b4s.cdlrawdp4fqg.us-east-1.rds.amazonaws.com;initial catalog=b4s_mg;uid=admin;pwd=Plx7fhsd89",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql")));

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
