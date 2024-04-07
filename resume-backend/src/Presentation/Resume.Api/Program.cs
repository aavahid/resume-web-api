using Microsoft.EntityFrameworkCore;
using Resume.Api.AppCode.DI;
using Resume.Application;

namespace Resume.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Host.UseServiceProviderFactory(new ResumeServiceProviderFactory());

            builder.Services.AddControllers();

            builder.Services.AddDbContext<DbContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"),opt =>
                {
                    opt.MigrationsHistoryTable("MigrationHistory");
                });
            });
            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<ApplicationModule>();
            });
            var app = builder.Build();
            app.MapControllers();

            app.Run();
        }
    }
}
