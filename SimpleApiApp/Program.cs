var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () => Environment.GetEnvironmentVariable("WEBSITE_SITE_NAME") ?? "Empty");

app.Run();
