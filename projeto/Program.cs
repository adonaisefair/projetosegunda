var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();//testando o comite

app.MapGet("/", () => "Hello World,let's get it aaaa");
app.MapGet("/", () => "Teste na api,criando....");
app.MapGet("/", () => "Teste 04/05/24");
app.MapGet("/", () => "Novo teste 17/05/24");
app.Run();

