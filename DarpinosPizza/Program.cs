using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DarpinosPizza.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionStr = "server=localhost;userid=root;password=895smigol;database=DarpinosPizza";


builder.Services.AddDbContext<DarpinosPizzaContext>(options =>
    options.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr)));

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
