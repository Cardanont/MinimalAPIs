using RPG_MinAPI.Data;
using RPG_MinAPI.Models;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/champion", (ILogger<Program> _logger) =>
{
    _logger.LogInformation("Gettitng all the Champions!");
    APIResponse response = new();
    response.Result = HallOfChampions.champions;
    response.IsSuccess = true;
    response.StatusCode = HttpStatusCode.OK;

    return Results.Ok(response);
}).WithName("GetChampions").Produces<APIResponse>(200);

app.MapGet("/api/champion/{id:int}", (int Id) =>
{
    APIResponse response = new();
    
    if(HallOfChampions.champions.FirstOrDefault(c => c.Id == Id) == null)
    {
        response.IsSuccess = false;
        response.StatusCode = HttpStatusCode.NotFound;
        response.ErrorMessages.Add("Champion not found!");
        return Results.NotFound(response);
    }
    else
    {
        response.Result = HallOfChampions.champions.FirstOrDefault(c => c.Id == Id);
        response.IsSuccess = true;
        response.StatusCode = HttpStatusCode.OK;
    }

    return Results.Ok(response);
}).WithName("GetChampion").Produces<APIResponse>(200);

app.UseHttpsRedirection();
app.Run();
