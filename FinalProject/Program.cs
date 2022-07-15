using FinalProject.Interface;
using FinalProject.Repository;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
//Postgresql yolumuzu belirledik.
builder.Services.AddDbContext<ArvatoDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("ArvatoDbContext")));

//Oluþturduðumuz interfaceleri repositoryler ile eþleþtirdik.
builder.Services.AddTransient<IMytable, MytableRepository>();
builder.Services.AddTransient<IGenres, GenresRepository>();
builder.Services.AddTransient<ITrendings, TrendingsRepository>();



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
