using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PasswordGenerator.Data;
using Volo.Abp.DependencyInjection;

namespace PasswordGenerator.EntityFrameworkCore;

public class EntityFrameworkCorePasswordGeneratorDbSchemaMigrator
    : IPasswordGeneratorDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePasswordGeneratorDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PasswordGeneratorDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PasswordGeneratorDbContext>()
            .Database
            .MigrateAsync();
    }
}
