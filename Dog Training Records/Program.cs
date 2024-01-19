var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();


app.MapGet("/", () => "Hello World!");

app.Run();