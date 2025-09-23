using WorkShopAPI.Domain.Utils;
using WorkShopAPI.RestService.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Service Configuration
builder.Services.AddApplication(builder);


var app = builder.Build();
app.UseCors("AngularServiceName".GetFromApp<string>());

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.DefaultModelsExpandDepth(-1); 
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
