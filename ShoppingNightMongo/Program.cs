using Microsoft.Extensions.Options;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.CustomerServices;
using ShoppingNightMongo.Services.ProductImageServices;
using ShoppingNightMongo.Services.ProductServices;
using ShoppingNightMongo.Services.SliderServices;
using ShoppingNightMongo.Settings;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Her Http iste�i i�in bir tane �ret, payla�.
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductImageService, ProductImageService>();
builder.Services.AddScoped<ISliderService, SliderService>();

// T�m profile s�n�flar�n� tara, bul ve otomatik olarak kaydet.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// Database konfig�rasyon ayarlar�n� yap�yoruz.
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));

//
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
