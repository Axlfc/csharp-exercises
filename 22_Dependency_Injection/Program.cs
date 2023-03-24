// Inyección de Dependencias

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) => 
        services.AddTransient<ITransientOperation, DefaultOperation>()
            .AddScoped<IScopedOperation, DefaultOperation>()
            .AddSingleton<ISingletonOperation, DefaultOperation>()
            .AddTransient<OperationLogger>())
    .Build();

EjemploScopes(host.Services, "Scope 1");
EjemploScopes(host.Services, "Scope 2");

await host.StartAsync();  // Inicio asíncrono

static void EjemploScopes(IServiceProvider services, string scope) {
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    OperationLogger logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scope}: -- Executing GetRequiredService<OperationLogger>()");
    Console.WriteLine();

    /*logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scope}: -- Executing GetRequiredService<OperationLogger>()");
    Console.WriteLine();*/

}