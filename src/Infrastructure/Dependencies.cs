using Microsoft.EntityFrameworkCore;
using Microsoft.eShopWeb.Infrastructure.Nft_Data;
using Microsoft.eShopWeb.Infrastructure.Data;
using Microsoft.eShopWeb.Infrastructure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Microsoft.eShopWeb.Infrastructure;

public static class Dependencies { 

    public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
    {
        var useOnlyInMemoryDatabase = false;
        if (configuration["UseOnlyInMemoryDatabase"] != null)
        {
            useOnlyInMemoryDatabase = bool.Parse(configuration["UseOnlyInMemoryDatabase"]);
        }

        if (useOnlyInMemoryDatabase)
        {
            services.AddDbContext<CatalogContext>(c =>
               c.UseInMemoryDatabase("Catalog"));
         
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseInMemoryDatabase("Identity"));
        }
        else
        {
            // use real database
            // Requires LocalDB which can be installed with SQL Server Express 2016
            // https://www.microsoft.com/en-us/download/details.aspx?id=54284
            var connectionString = configuration.GetConnectionString("CatalogConnection");
            services.AddDbContext<CatalogContext>(c =>
                c.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            var conectionString = configuration.GetConnectionString("IdentityConnection");
            
            services.AddDbContext<AppContext>(c =>
                c.UseMySql(conectionString, ServerVersion.AutoDetect(conectionString),
        o => o.SchemaBehavior(MySqlSchemaBehavior.Ignore)));    

            // Add Identity DbContext
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseMySql(conectionString, ServerVersion.AutoDetect(conectionString),
        o => o.SchemaBehavior(MySqlSchemaBehavior.Ignore)));

        }
    }
}
