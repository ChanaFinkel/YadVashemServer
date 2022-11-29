using Registrant.Data.Classes;
using Registrant.Data.Interfaces;
using Registrant.Service.Classes;
using Registrant.Service.Interfaces;
using Registrant.WebApi.MiddleWres;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IRegistrantService,RegistrantService>();
builder.Services.AddSingleton<IRegistrantData,RegistrantData>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHandleErrorMiddleware();

app.MapControllers();

app.Run();
