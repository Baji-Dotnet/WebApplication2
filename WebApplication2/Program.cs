using Microsoft.AspNetCore.OData;
using Newtonsoft.Json.Serialization;
using System.Text.Json;
using WebApplication2.ServiceCollections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Odata filter configuration
builder.Services.AddControllers().AddOData(options => options.Select().Filter());

//Json data model binding configurations configuration
builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
builder.Services.AddControllers()
    .AddNewtonsoftJson(o =>
    {
        DefaultContractResolver contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        };
        o.SerializerSettings.ContractResolver = contractResolver;
    })
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    })
    ;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Project services collections configured here.
builder.Services.AddProjectServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();