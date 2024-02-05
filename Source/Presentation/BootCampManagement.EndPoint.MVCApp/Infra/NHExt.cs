using NHibernate.Cfg;

namespace BootCampManagement.EndPoint.MVCApp.Infra;

public static class NHExt
{
    public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
    {
        var configuration = new Configuration();
        connectionString = "Server=.;Database=Bank;TrustServerCertificate=True;Integrated Security=SSPI;";
        configuration.AddAssembly("Persistence");

        configuration.DataBaseIntegration(c =>
        {
            c.Dialect<NHibernate.Dialect.MsSql2012Dialect>();
            c.ConnectionString = connectionString;
            c.LogFormattedSql = true;
            c.LogSqlInConsole = true;
        });

        NHibernate.ISessionFactory sessionFactory = configuration.BuildSessionFactory();

        services.AddSingleton(sessionFactory);
     

        services.AddScoped(factory => sessionFactory.OpenSession());


        return services;
    }
}
