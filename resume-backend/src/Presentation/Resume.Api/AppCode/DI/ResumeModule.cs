using Autofac;
using Resume.DataAccessLayer;

namespace Resume.Api.AppCode.DI
{
    class ResumeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyModules(typeof(DataAccessModule).Assembly);
        }
    }
}
