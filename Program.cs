using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// deixa o DB como serviço, podendo usar em várias aplicações
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapControllers();


app.Run();
