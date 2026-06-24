using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//dotnet tool install --global dotnet-ef --version 8.0.0
//Install-Package Microsoft.EntityFrameworkCore.Tools


//dotnet ef migrations add InitialCreate -s SkyShop -p Infrastructure

//Add-Migration InitialCreate -Project Infrastructure -StartupProject SkyShop

//dotnet ef migrations add InitialCreate --project Infrastructure --startup-project SkyShop

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
