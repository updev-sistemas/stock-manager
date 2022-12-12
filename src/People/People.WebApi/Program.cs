using FluentValidation;
using FluentValidation.AspNetCore;
using UpDEV.StockManager.People.BusinessRules.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddValidatorsFromAssemblyContaining<PersonValidator>();

builder.Services.AddFluentValidationAutoValidation(config =>
{
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
    config.ImplicitlyValidateRootCollectionElements = true;
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
