using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

//Auxiliar no mapeamento das paginas.
app.UseRouting();
app.MapRazorPages();

app.Run();
