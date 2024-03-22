using System.Runtime.Serialization;
using CleanArchitecture.Persistence;
using CleanArchitecture.Persistence.Context;
using CleanArchitecture.Application.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<Contexto>
//    (Options => Options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MVC_CRUD_DOTNET_SQL;Trusted_Connection=True;MultipleActiveResultSets=true"));

builder.Services.ConfiguretionPersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();
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

CreateDatabase(app);

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();
}