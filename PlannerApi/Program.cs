var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Planner API");
app.MapGet("/produtos", () => "Produtos");
app.MapGet("/pessoas", () => "Pessoas");
app.MapGet("/pessoas/{id}", () => "Pessoas 1");

app.MapPost("/", () => "Post");
app.MapPost("/pessoas", () => "Post pessoas");
app.MapPost("/produtos", () => "Post produtos ");

app.MapPut("/", () => "Put");
app.MapPut("/pessoas", () => "Put pessoas");
app.MapPut("/produtos", () => "Put produtos ");

app.MapDelete("/", () => "Delete");
app.MapDelete("/pessoas", () => "Delete pessoas");
app.MapDelete("/produtos", () => "Delete produtos ");

app.Run();
