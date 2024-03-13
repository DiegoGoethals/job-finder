using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add database service
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options
    .UseSqlServer(builder.Configuration.GetConnectionString("DefaultDb")));

// Add identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
    {
        //configure options for testing purposes
        options.Password.RequiredUniqueChars = 0;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 6;
    }).AddEntityFrameworkStores<ApplicationDbContext>()
     .AddSignInManager<SignInManager<ApplicationUser>>()
    .AddDefaultTokenProviders();
    // Add services to the container.
    builder.Services.ConfigureApplicationCookie(options =>
        options.AccessDeniedPath = "/account/login"
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
