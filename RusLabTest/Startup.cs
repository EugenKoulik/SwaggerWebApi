using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using RusLabTest.Services;

namespace RusLabTest;

public class Startup
{
    public IConfiguration Configuration { get; }
        
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
        
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddServices();
        services.AddTransient<CourseService>();
        services.AddDbContext<RusLabDbContext>(item 
            => item.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
        services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddAutoMapper(typeof(Startup));
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }
 
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
 
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
        
        app.Run();
    }
}