using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebbShop_API.Contexts;
using WebbShop_API.Data;

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
      services.AddScoped<ICustomerRepository, CustomerRepository>();

      services.AddDbContext<DataContext>(options => options.UseSqlite("Data Source=webbshop.db"));

      // services.AddDbContext<DataContext>(x => x.UseSqlite
      // (Configuration.GetConnectionString("DefaultConnection")));
      services.AddControllers();
      services.AddCors();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      // app.UseHttpsRedirection();

      app.UseRouting();

      // No CORS error when fetching data
      app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
        // endpoints.MapFallbackToAreaController("Index", "Fallback");
      });
    }
  }
}
