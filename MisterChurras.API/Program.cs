var builder = WebApplication.CreateBuilder(args);

// --- 1. Configuração dos Serviços ---
// Avisa ao .NET: "Vou usar Controllers nessa aplicação"
builder.Services.AddControllers();

var app = builder.Build();

// --- 2. Configuração do Pipeline ---
//app.UseHttpsRedirection();

// Avisa ao app: "Mapeie os controllers que encontrar e crie as rotas"
app.MapControllers();

app.Run();