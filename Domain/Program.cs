var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        options.ViewLocationFormats.Clear();
        options.ViewLocationFormats.Add("/Aplication/Views/{1}/{0}.cshtml"); // Custom location
        options.ViewLocationFormats.Add("/Aplication/Views/Shared/{0}.cshtml"); // Shared folde
    });

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
    name: "default",  // This is the name of the route, which is usually used to reference the route in your application
    pattern: "{controller=User}/{action=First}/{id?}");  // The URL pattern for the route

app.Run();
