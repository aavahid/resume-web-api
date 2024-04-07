using Autofac;
using Microsoft.EntityFrameworkCore;
using Resume.DataAccessLayer.Contexts;

namespace Resume.DataAccessLayer;

public class DataAccessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<DataContext>()
            .As<DbContext>()
            .OwnedByLifetimeScope();
    }
}
