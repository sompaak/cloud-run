var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";
var target = Environment.GetEnvironmentVariable("TARGET") ?? "World V1.2";

var app = builder.Build();

app.MapGet("/", () => $"Hello {target}!");

app.Run(url);
