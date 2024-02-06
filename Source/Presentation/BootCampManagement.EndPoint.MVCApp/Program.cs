
using Application.Base;
using BootCampManagement.EndPoint.MVCApp.Infra;
using Domain.Contract.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var connection = "Server=.;Database=Bank;TrustServerCertificate=True;Integrated Security=SSPI;";
builder.Services.AddNHibernate(connection);


builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
