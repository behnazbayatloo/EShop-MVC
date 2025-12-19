using EShop.Domain.AppServices;
using EShop.Domain.Core.BasketAgg.AppService;
using EShop.Domain.Core.BasketAgg.Data;
using EShop.Domain.Core.BasketAgg.Service;
using EShop.Domain.Core.BasketItemAgg.Data;
using EShop.Domain.Core.BasketItemAgg.Service;
using EShop.Domain.Core.CategoryAgg.AppService;
using EShop.Domain.Core.CategoryAgg.Data;
using EShop.Domain.Core.CategoryAgg.Service;
using EShop.Domain.Core.OrderAgg.AppService;
using EShop.Domain.Core.OrderAgg.Data;
using EShop.Domain.Core.OrderAgg.Service;
using EShop.Domain.Core.OrderItemAgg.Data;
using EShop.Domain.Core.OrderItemAgg.Service;
using EShop.Domain.Core.ProductAgg.AppService;
using EShop.Domain.Core.ProductAgg.Data;
using EShop.Domain.Core.ProductAgg.Service;
using EShop.Domain.Core.UserAgg.Data;
using EShop.Domain.Core.UserAgg.Entity;
using EShop.Domain.Core.UserAgg.Service;
using EShop.Domain.Services;
using EShop.Infra.Db.Sql.DbCtx;
using EShop.Infra.Repository.ApplicationUserRepoAgg;
using EShop.Infra.Repository.BasketItemRepoAgg;
using EShop.Infra.Repository.BasketRepoAgg;
using EShop.Infra.Repository.CategoryRepoAgg;
using EShop.Infra.Repository.OrderItemRepoAgg;
using EShop.Infra.Repository.OrderRepoAgg;
using EShop.Infra.Repository.ProductRepoAgg;
using EShop.Presentation.MVC.Framework;



//using EShop.Presentation.MVC.Data;
using EShop.Presentation.MVC.Middlewares;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<IProductAppService, ProductAppService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService,OrderService>();
builder.Services.AddScoped<IOrderAppService,OrderAppService>();
builder.Services.AddScoped<IOrderItemRepository,OrderItemRepository>();
builder.Services.AddScoped<IOrderItemService,OrderItemService>();
builder.Services.AddScoped<IBasketRepository, BasketRepository>();
builder.Services.AddScoped<IBasketAppService,BasketAppService>();
builder.Services.AddScoped<IBasketService, BasketService>();
builder.Services.AddScoped<IBasketItemRepository,BasketItemRepository>();
builder.Services.AddScoped<IBasketItemService,BasketItemService>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IApplicationUserService,ApplicationUserService>();
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>()
    .AddErrorDescriber<PersianIdentityErrorDescriber>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddDistributedMemoryCache(); 
builder.Services.AddSession(options => 
{
     options.IdleTimeout = TimeSpan.FromMinutes(30); 
    options.Cookie.HttpOnly = true; options.Cookie.IsEssential = true; 
});
builder.Host.UseSerilog((context, configuration) =>
{
    configuration.ReadFrom.Configuration(context.Configuration);
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
   

    // User settings.
    
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

    options.LoginPath = "/Identity/Login/Login";
    options.AccessDeniedPath = "/Identity/Login/AccessDenied";
    options.SlidingExpiration = true;
}); 



var app = builder.Build();
app.UseMiddleware<RequestLoggingMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseExceptionHandler("/Home/Error");
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}").WithStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
