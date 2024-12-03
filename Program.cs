using CadastroDeCliente.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//Criando o apontamento no banco de dados
builder.Services.AddDbContext<CadastroDeCliente.Data.AppCont>(options =>
{
    options.UseSqlServer(builder

        .Configuration
        .GetConnectionString("DBCadastroDeClientes"));
});

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

AppDBInitializer.Seed(app);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cadastro_Cliente}/{action=Index}/{id?}");

app.Run();
