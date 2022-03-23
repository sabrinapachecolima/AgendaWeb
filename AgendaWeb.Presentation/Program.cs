using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);


// confugurar o projeto para MVC
builder.Services.AddControllersWithViews();

// ler a connctionString mapeada no arquivo 'appsettings.json'
var connectionSrtring = builder.Configuration.GetConnectionString("BDAgendaWeb");
// fazendo a injecao de dependecia para que a connectionString possa ser passada´para a class TerefaRepository e as mesma ser inicializada pelo sistema
builder.Services.AddTransient<ITarefaRepositories>
   (map => new TarefaRepositories(connectionSrtring));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// primeira pagina para abrir do projeto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
