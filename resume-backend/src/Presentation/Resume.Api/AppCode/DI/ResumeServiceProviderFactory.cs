using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace Resume.Api.AppCode.DI
{
    class ResumeServiceProviderFactory : AutofacServiceProviderFactory
    {
        public ResumeServiceProviderFactory()
            : base(OnRegister)
        {
            
        }

        private static void OnRegister(ContainerBuilder builder)
        {
            builder.RegisterModule<ResumeModule>();
        }
    }
}
