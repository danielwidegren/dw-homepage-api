using Azure.Identity;
using Azure.Storage.Blobs;
using dw_homepage_api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton(new SongService());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    builder.Configuration.AddUserSecrets<Program>();
}

app.UseHttpsRedirection();

app.MapGet("/songs", (SongService songService) =>
{
    var songs = songService.GetSongs();
    var result = new Dictionary<string, Song[]>
    {
        { "data", songs }
    };
    return Results.Ok(result);
})
.WithName("GetSongs");

var connectionString = builder.Configuration["BlobConnectionString"];

app.MapGet("/play/{filename}", async (string filename) =>
{
    BlobClient? blobClient = null;
    if (app.Environment.IsDevelopment())
    {
        blobClient = new BlobContainerClient(connectionString, "music1").GetBlobClient(filename);
    }
    else
    {
        var blobServiceClient = new BlobServiceClient(new Uri("https://music.blob.core.windows.net/"), new DefaultAzureCredential());
        var containerClient = blobServiceClient.GetBlobContainerClient("music1");
        blobClient = containerClient.GetBlobClient(filename);
    }

    if (blobClient == null)
    {
        return Results.InternalServerError();
    }

    if (!await blobClient.ExistsAsync())
    {
        return Results.NotFound();
    }

    var blobStream = await blobClient.OpenReadAsync();
    var mimeType = "audio/wav";
    return Results.File(blobStream, contentType: mimeType, fileDownloadName: filename);
})
.WithName("playFile");

// app.MapGet("/play/{filename}", (string filename) =>
// {
//     // Sanitize filename.
//     if (Path.GetFileName(filename) != filename)
//     {
//         return Results.BadRequest("Invalid filename.");
//     }
//     var basePath = Path.Combine(app.Environment.ContentRootPath, "files");
//     var path = Path.GetFullPath(Path.Combine(basePath, filename));
//     // Check for path traversal.
//     if (!path.StartsWith(basePath))
//     {
//         return Results.BadRequest("Invalid filename.");
//     }
//     if (!File.Exists(path))
//     {
//         return Results.NotFound("Song not found.");
//     }
//     var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
//     var mimeType = "audio/wav";
//     return Results.File(path, contentType: mimeType, fileDownloadName: filename);
// })
// .WithName("playFile");


app.Run();
