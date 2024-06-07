using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Pri.Api.Pe.Api.Requirements;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Core.Interfaces.Services;
using Pri.Api.Pe.Core.Services;
using Pri.Api.Pe.Infrastructure.Data;
using Pri.Api.Pe.Infrastructure.Repositories;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add database service
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options
    .UseSqlServer(builder.Configuration.GetConnectionString("DefaultDb")));

// Add JWT authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidAudience = builder.Configuration["JWTConfiguration:Audience"],
        ValidIssuer = builder.Configuration["JWTConfiguration:Issuer"],
        IssuerSigningKey =
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWTConfiguration:SecretKey"]))
    };
});

builder.Services.AddCors();

// Add repositories to the container.
builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<IUserRepository<ApplicationUser>, UserRepository>();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IApplicationStatusRepository, ApplicationStatusRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();

// Add services to the container.
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IMessageService, MessageService>();

// Add requirements to the container.
builder.Services.AddScoped<IAuthorizationHandler, IsEmployerRequirementHandler>();
builder.Services.AddScoped<IAuthorizationHandler, IsEmployeeRequirementHandler>();
builder.Services.AddScoped<IAuthorizationHandler, IsSameCandidateRequirementHandler>();
builder.Services.AddScoped<IAuthorizationHandler, IsSenderRequirementHandler>();
builder.Services.AddScoped<IAuthorizationHandler, IsSenderOrReceiverRequirementHandler>();
builder.Services.AddScoped<IAuthorizationHandler, IsReviewerRequirementHandler>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Employer", policy =>
        {
            policy.RequireClaim(ClaimTypes.Role, "Employer");
        }
    );
    options.AddPolicy("Employee", policy =>
    {
        policy.RequireClaim(ClaimTypes.Role, "Employee");
    });
    options.AddPolicy("IsEmployer", policy => policy.Requirements.Add(new IsEmployerRequirement()));
    options.AddPolicy("IsEmployee", policy => policy.Requirements.Add(new IsEmployeeRequirement()));
    options.AddPolicy("IsSameCandidate", policy => policy.Requirements.Add(new IsSameCandidateRequirement()));
    options.AddPolicy("IsSender", policy => policy.Requirements.Add(new IsSenderRequirement()));
    options.AddPolicy("IsSenderOrReceiver", policy => policy.Requirements.Add(new IsSenderOrReceiverRequirement()));
    options.AddPolicy("IsReviewer", policy => policy.Requirements.Add(new IsReviewerRequirement()));
});

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
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });

    // Add JWT authentication
    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter JWT Bearer token **only**",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    };
    c.AddSecurityDefinition("Bearer", securityScheme);

    var securityRequirement = new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    };
    c.AddSecurityRequirement(securityRequirement);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyHeader();
    options.AllowAnyMethod();
});

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
