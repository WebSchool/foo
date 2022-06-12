using Frontend.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FrontendDbContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

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

// docker login -u webschool
// docker network create foo

// docker build -t webschool/frontend:latest -f .\src\Frontend\Dockerfile .
// docker build -t webschool/api:latest -f .\src\Api\Dockerfile .

// docker run -d --network foo -p 5000:80 webschool/frontend
// docker run -d --network foo --network-alias api webschool/api

