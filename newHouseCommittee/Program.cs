using Microsoft.Extensions.DependencyInjection;
using newHouseCommittee.Entities;
using Solid.Core;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Core.Servies;
using Solid.Data.Repositories;
using Solid.Service;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBiuldingRepository, BiuldingRepository>();

builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();

builder.Services.AddScoped<ITenantRepository, TenantRepository>();

builder.Services.AddScoped<IBiuldingService,BiuldingService>();

builder.Services.AddScoped<IPaymentService, PaymentService>();

builder.Services.AddScoped<ITenantService,TenantService>();

builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
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
