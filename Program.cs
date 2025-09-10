var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/weatherforecast", () =>
{
    var path = Path.Combine(app.Environment.ContentRootPath, "files", "magnolia-blues.wav");
    if (!File.Exists(path))
    {
        return Results.NotFound("Song not found.");
    }
    var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
    var mimeType = "audio/wav";
    return Results.File(path, contentType: mimeType, fileDownloadName: "magnolia.wav");
})
.WithName("GetWeatherForecast");

app.Run();
