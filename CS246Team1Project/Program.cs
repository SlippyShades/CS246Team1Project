using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CS246Team1Project.Data;
using CS246Team1Project.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CS246Team1ProjectContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CS246Team1ProjectContext") ?? throw new InvalidOperationException("Connection string 'CS246Team1ProjectContext' not found.")));

// Register the repository
// For production, use the real SQLite repository
builder.Services.AddScoped<IStudentRepository, InMemoryStudentRepository>();

// For testing, you can switch to in-memory:
// builder.Services.AddSingleton<IStudentRepository, InMemoryStudentRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Initialize the database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<CS246Team1ProjectContext>();
        // This creates the database and schema if it doesn't exist
        context.Database.EnsureCreated();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the database.");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.UseEndpoints(static endpoints =>
{
    _ = endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );  
});

app.Run();
