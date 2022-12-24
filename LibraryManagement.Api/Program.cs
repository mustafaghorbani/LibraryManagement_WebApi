using LibraryManagement.Infrastructure.Engine;
using LibraryManagement.Infrastructure.Helpers;
using LibraryManagement.Repository;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(LibreryManagementMediatrEntryPoint).Assembly);

CommonHelper.GetAllInstancesOf<IConfigurationRegister>()?.OrderBy(x => x.Order).ToList()
                .ForEach(x => x.Configure(builder.Services, builder.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
