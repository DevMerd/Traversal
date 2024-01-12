using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.WebUI.ViewComponents.Default;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IDestinationService, DestinationManager>();
builder.Services.AddSingleton<IDestinationDal, EfDestinationDal>();

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
