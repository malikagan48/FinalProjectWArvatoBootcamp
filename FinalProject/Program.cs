using FinalProject.Interface;
using FinalProject.Repository;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
//Postgresql yolumuzu belirledik.
builder.Services.AddDbContext<ArvatoDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("ArvatoDbContext")));

//Oluþturduðumuz interfaceleri repositoryler ile eþleþtirdik.
builder.Services.AddTransient<IMovies, MoviesRepository>();
builder.Services.AddTransient<IGenres, GenresRepository>();
builder.Services.AddTransient<ITrendings, TrendingsRepository>();



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    opt => // Swagger Configuration
    {
        opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MaliKagan-Arvato ASP.NET Bootcamp Graduation", Version = "v1" });
        opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please enter token",
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "bearer"
        });
        opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
    });
builder.Services.AddHttpClient();
builder.Services.AddMvc();
//Tokenýmýzýn tanýmlamasýný yaptýk.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
