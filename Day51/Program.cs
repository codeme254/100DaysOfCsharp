var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Welcome to the application");
app.MapGet("/hello-world", () => "Hello, World");

app.Run();