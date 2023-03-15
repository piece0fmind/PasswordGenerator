using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace PasswordGenerator;

public class PasswordGeneratorWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<PasswordGeneratorWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
