using System.Net;
using System.Text;
using WebbShop_API.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using WebbShop_API.Helpers;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace WebbShop.API
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<WebbShop_API.Contexts.DataContext>(options => options.UseSqlite("Data Source=webbshop.db"));
      services.AddControllers().AddNewtonsoftJson(opt =>
      {
        opt.SerializerSettings.ReferenceLoopHandling =
        Newtonsoft.Json.ReferenceLoopHandling.Ignore;
      });
      services.AddCors();
      services.AddAutoMapper(typeof(CustomerRepository).Assembly);
      services.AddScoped<IAdminRepository, AdminRepository>();
      services.AddScoped<ICustomerRepository, CustomerRepository>();
      services.AddScoped<IShoesRepository, ShoesRepository>();
      services.AddScoped<ISizeRepository, SizeRepository>();
      services.AddScoped<IColorRepository, ColorRepository>();

      services.AddScoped<IAuthRepository, AuthRepository>();

      services.AddAuthorization(options =>
      {
        options.AddPolicy("RequireCustomerRole", policy => policy.RequireRole("Customer"));
      });

      services.AddAuthentication(options =>
      {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      }).AddJwtBearer(jwtBearerOptions =>
      {
        jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters()
        {
          ValidateIssuer = false,
          ValidateAudience = false,
          ValidateLifetime = false,
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("AppSettings:Token").Value))
        };
      });

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // global exception handler
        app.UseExceptionHandler(builder =>
        {
          builder.Run(async context =>
          {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var error = context.Features.Get<IExceptionHandlerFeature>();
            if (error != null)
            {
              context.Response.AddApplicationError(error.Error.Message);
              await context.Response.WriteAsync(error.Error.Message);
            }
          });
        });
      }

      // app.UseHttpsRedirection();

      app.UseRouting();

      // No CORS error when fetching data
      app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

      //Enable Authentication
      app.UseAuthentication();
      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
        // endpoints.MapFallbackToAreaController("Index", "Fallback");
      });
    }
  }
}
