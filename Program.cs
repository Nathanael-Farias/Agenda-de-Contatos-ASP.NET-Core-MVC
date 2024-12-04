using Microsoft.EntityFrameworkCore; // Certifique-se de importar este namespace
using ProjetoMVC_DIO.Context; // Certifique-se de usar o namespace do seu contexto

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AgendaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
