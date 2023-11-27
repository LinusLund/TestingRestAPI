using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using TestingRestAPI.Contexts;
using TestingRestAPI.Helpers.Repositories;
using TestingRestAPI.Helpers.Services;
using TestingRestAPI.Interfaces;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddDbContext<PrintContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SQL")));







//Repos
builder.Services.AddScoped<ReceiptRepository>();
//Services
builder.Services.AddScoped<IReceiptService, ReceiptService>();




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
