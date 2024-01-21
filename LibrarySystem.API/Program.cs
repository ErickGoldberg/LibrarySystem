using FluentValidation.AspNetCore;
using LibrarySystem.API.Filters;
using LibrarySystem.Application.Services.Implementations;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Application.Validators.Users;
using LibrarySystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ILoanService, LoanService>();

// Validations (Fluent Validators)
builder.Services.AddControllers(options => options.Filters.Add(typeof(ValidationFilter)))
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateUserValidator>());

// Connect Connection String
builder.Services.AddDbContext<LibrarySystemDbContext>(options 
    => options.UseSqlServer(builder.Configuration.GetConnectionString("LibrarySystemDb")));

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
