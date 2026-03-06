var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// 🔥 SESSION CONFIGURATION
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

// 🔥 VERY IMPORTANT
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();