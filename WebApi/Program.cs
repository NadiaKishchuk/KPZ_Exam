using Exam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Mapper;
using Services.Repository.Doctors;
using Services.Repository.Records;
using Services.Services;
using Services.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

new DbMapper().Create();

builder.Services.AddSingleton<IDoctorSevice, DoctorService>();
builder.Services.AddSingleton<IRecordService, RecordService>();

builder.Services.AddSingleton<IRecordRepositories, RecordRepositories>();
builder.Services.AddSingleton<IDoctorRepositories, DoctorRepositories>();

builder.Services.AddSingleton<PsychotherapeuticClinicContext, PsychotherapeuticClinicContext>();
builder.Services.AddDbContext<PsychotherapeuticClinicContext>(
    option => option
    .UseSqlServer(builder.Configuration.GetConnectionString("ClinicConnectionString")), ServiceLifetime.Singleton);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(x =>
{
    x.AddDefaultPolicy(s =>
    {
        s.AllowAnyMethod();
        s.AllowAnyOrigin();
        s.AllowAnyHeader();
    });
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

app.UseCors();
app.MapControllers();

app.Run();
