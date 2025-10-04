var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Permite acessar os arquivos HTML, CSS e JS da pasta wwwroot
app.UseStaticFiles();

// Quando alguém acessar "/", redireciona pra index.html
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
