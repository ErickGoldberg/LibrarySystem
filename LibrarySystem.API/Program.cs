using FluentValidation.AspNetCore;
using LibrarySystem.API.Filters;
using LibrarySystem.Application.Commands.CreateUser;
using LibrarySystem.Application.Validators.Users;
using LibrarySystem.Core.Repositories;
using LibrarySystem.Infrastructure.Persistence;
using LibrarySystem.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Validations (Fluent Validators)
builder.Services.AddControllers(options => options.Filters.Add(typeof(ValidationFilter)))
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateUserValidator>());

// Connect Connection String
builder.Services.AddDbContext<LibrarySystemDbContext>(options 
    => options.UseSqlServer(builder.Configuration.GetConnectionString("LibrarySystemDb")));

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(CreateUserCommand).Assembly);
    // Add other assemblies or configurations as needed
});

// Dependency Injection
builder.Services.AddScoped<IBookRepository, BookRepository>();

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
