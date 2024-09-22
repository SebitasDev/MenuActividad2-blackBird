using FluentValidation;
using menuActividd2.Data;
using menuActividd2.Repository.Usuarios;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddDbContext<MenuContext>(options => 
    options.UseMySql(
        builder.Configuration.GetConnectionString("MyConnection"),
        ServerVersion.Parse("8.0.20-mysql")
    )
);

builder.Services.AddValidatorsFromAssemblyContaining<Program>(); //Se agregan todas las validaciones que configuremos en el program
builder.Services.AddFluentValidationAutoValidation(); //Las validaciones que hacemos arriba las aplicamos de manera automatica

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

