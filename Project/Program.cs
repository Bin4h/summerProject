using Data_Base.Extentions;
using Microsoft.OpenApi.Models;
using Project;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "summerProject",
        Description = "Rowi project",
    });
});

var connectionString = builder.Configuration["ConnectionStrings:summerProject"];
if (connectionString != null)
{
    Startup.AddDbContext(builder.Services, connectionString);
}

Startup.AddAutoMapper(builder.Services);
Startup.ConfigureServices(builder.Services);

RepositoryExtention.AddRepositories(builder.Services);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project"));
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

