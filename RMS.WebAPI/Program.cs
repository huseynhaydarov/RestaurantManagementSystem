using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RMS.Application.Common.Interfaces;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Mappers;
using RMS.Application.Services;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;
using RMS.Infrastructure.Repository;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<EFContext>()
    .AddApiEndpoints();

builder.Services.AddAuthentication()
    .AddBearerToken(IdentityConstants.BearerScheme);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IBaseRepository<Customer>), typeof(BaseRepository<Customer>));
builder.Services.AddScoped(typeof(IBaseRepository<Order>), typeof(BaseRepository<Order>));
builder.Services.AddScoped(typeof(IBaseRepository<MenuItem>), typeof(BaseRepository<MenuItem>));
builder.Services.AddScoped(typeof(IBaseRepository<OrderItem>), typeof(BaseRepository<OrderItem>));



builder.Services.AddScoped<IBaseService<Customer>, CustomerService>();
builder.Services.AddScoped<IBaseService<Order>, OrderService>();
builder.Services.AddScoped<IBaseService<MenuItem>, MenuItemService>();
builder.Services.AddScoped<IBaseService<OrderItem>, OrderItemService>();
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration).Assembly);
builder.Services.AddDbContext<EFContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGroup("/Account").MapIdentityApi<IdentityUser>();

app.MapControllers();

app.Run();
