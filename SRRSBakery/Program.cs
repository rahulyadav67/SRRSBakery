using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SRRSBakery.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IitemRepository, ItemRepository>();
builder.Services.AddScoped <ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp)); //for shopping cart
builder.Services.AddHttpContextAccessor();  //session,user for shopping cart
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddSession();
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
app.UseSession();
app.UseRouting();
app.UseAuthentication(); //for login
app.UseAuthorization(); 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=ListCategory}/{id?}");
app.MapRazorPages(); //for login
app.Run();
