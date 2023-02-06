using ProjSMGBit.Application.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Initializer.Configure(builder.Services, "Server=127.0.0.1; Port=3306; Database=projsmgbit; Uid=root; Pwd=root;");
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
