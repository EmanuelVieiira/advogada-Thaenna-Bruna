var builder = WebApplication.CreateBuilder(args);

// ✅ ADICIONE ESTA LINHA (para suporte a Razor Pages)
builder.Services.AddRazorPages();

var app = builder.Build();

// ✅ Permite acessar os arquivos CSS e JS da pasta wwwroot
app.UseStaticFiles();

// ✅ ADICIONE ESTA LINHA (para roteamento)
app.UseRouting();

// ✅ MUDE ESTA LINHA (para usar Razor Pages)
app.MapRazorPages();

app.Run();