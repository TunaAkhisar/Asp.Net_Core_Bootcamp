using BloggApp.Data.Abstract;
using BloggApp.Data.Concrate;
using BloggApp.Data.Concrate.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogContext>(
    options => {
        var config = builder.Configuration;
        var connectionString = config.GetConnectionString("slq_conntection");
        options.UseSqlite(connectionString);
    }
);

builder.Services.AddScoped<IPostRepository,EfPostRepository>();

var app = builder.Build();

app.UseStaticFiles();

SeedData.TestVerileriniDoldur(app);

app.MapDefaultControllerRoute();

app.MapGet("/", () => "Hello World!");

app.Run();
