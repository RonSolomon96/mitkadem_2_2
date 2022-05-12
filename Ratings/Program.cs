using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ratings.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RatingsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RatingsContext") ?? throw new InvalidOperationException("Connection string 'RatingsContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=RatingObjs}/{action=Index}/{id?}");

app.Run();
