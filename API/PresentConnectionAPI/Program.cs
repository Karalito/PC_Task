using Microsoft.OpenApi.Models;
using PresentConnectionAPI.Models;
using PresentConnectionAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swaggerGenOptions =>
{
    swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo { Title = "Present Connection API", Version = "v1" }); 
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(swaggerUIOptions =>
{
    swaggerUIOptions.DocumentTitle = "Present Connection API";
    swaggerUIOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API for Present Connection");
    swaggerUIOptions.RoutePrefix = String.Empty;
});

app.UseHttpsRedirection();

app.UseCors("CORSPolicy");

app.MapGet("/get-all-records", async () => await RecordsRepository.GetRecordsAsync()).WithTags("Records Endpoints");
app.MapGet("/get-record-by-id/{id}", async (int id) =>
{
    Record recordToReturn = await RecordsRepository.GetRecordByIdAsync(id);

    if (recordToReturn == null) return Results.BadRequest();

    return Results.Ok(recordToReturn);
}).WithTags("Records Endpoints");
app.MapPost("/create-record", async(Record record) =>
{
    bool created = await RecordsRepository.CreateRecordAsync(record);

    if (!created) return Results.BadRequest();

    return Results.Ok("Record was Created");
}).WithTags("Records Endpoints");
app.MapPut("/update-record", async (Record record) =>
{
    bool updated = await RecordsRepository.UpdateRecordAsync(record);

    if (!updated) return Results.BadRequest();

    return Results.Ok("Record was Updated");
}).WithTags("Records Endpoints");
app.MapDelete("/delete-record-by-id/{id}", async (int id) =>
{
    bool deleted = await RecordsRepository.DeleteRecordAsync(id);

    if (!deleted) return Results.BadRequest();

    return Results.Ok("Record was Deleted");
}).WithTags("Records Endpoints");

app.Run();
