using Microsoft.EntityFrameworkCore;
using Resume.Api.AppCode.DI;

namespace Resume.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Host.UseServiceProviderFactory(new ResumeServiceProviderFactory());

            builder.Services.AddDbContext<DbContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"),opt =>
                {
                    opt.MigrationsHistoryTable("MigrationHistory");
                });
            });

            var app = builder.Build();

            app.Run();
        }
    }
}
