using Autofac;
using Resume.DataAccessLayer;
using Resume.Repository;

namespace Resume.Api.AppCode.DI
{
    class ResumeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyModules(typeof(DataAccessModule).Assembly);
            builder.RegisterAssemblyTypes(typeof(IRepositoryReferance).Assembly)
                .AsImplementedInterfaces();
        }
    }
}
