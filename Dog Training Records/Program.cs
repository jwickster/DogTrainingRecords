using Dog_Training_Records.Data;


var builder = WebApplication.CreateBuilder(args);
ConfigureServices(builder.Services);
var app = builder.Build();
ConfigurePipeline(app);

app.Run();

void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
    services.AddServerSideBlazor();
    services.AddHttpClient();
    services.AddDbContext<DogTrainingContext>(options => 
        options.UseSqlite("Data Source=dogTraining.db"));
}

void ConfigurePipeline(WebApplication app)
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();
    
    app.MapBlazorHub();
    app.MapFallbackToPage("/_Host");
    app.MapGet("/", () => "Hello World!");

    InitializeDatabase(app);
}

async void InitializeDatabase(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<DogTrainingContext>();
    if (await db.Database.EnsureCreatedAsync())
    {
        await SeedData.InitializeAsync(db);
    }
}