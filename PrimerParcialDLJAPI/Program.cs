using PrimerParcialDLJAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// === Servicios ===
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks(); // Para el endpoint /ping

var app = builder.Build();

// === Middleware ===
// El enunciado exige: "dejarlo accesible en el API desplegada"
// Por eso Swagger se habilita SIN condición (funciona en Azure)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

// Health check accesible en /ping
app.MapHealthChecks("/ping");

// Controladores de la API
app.MapControllers();

app.Run();