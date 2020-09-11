using Core.Domain.UOW;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.DependencyInjection
{
    public static class DomainDependecies
    {
        public static void InjectDomainDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AppRepositoryInjection(configuration);
            services.AddTransient<IUOW, UOW>();
        }
        public static void AppRepositoryInjection(this IServiceCollection service, IConfiguration configuration)
        {
            var IdentityConnection = configuration.GetConnectionString("DefaultConnection");
            string assemblyName = typeof(AppDbContext).Namespace;

            service.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                   IdentityConnection,
                   optionsBuilder => optionsBuilder.MigrationsAssembly("Domain"))
                );
        }
    }
}
