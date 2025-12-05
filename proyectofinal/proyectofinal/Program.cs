using Microsoft.EntityFrameworkCore;
using proyectofinal.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MydbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Swagger solo disponible en /swagger, no como página principal
    app.UseSwagger();
    app.UseSwaggerUI();
}app.UseHttpsRedirection();

// Configurar página de inicio
app.UseDefaultFiles(); // Esto buscará index.html automáticamente

app.UseStaticFiles();

app.UseCors(builder =>
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());


app.UseAuthorization();

app.MapControllers(); 

app.Run();
