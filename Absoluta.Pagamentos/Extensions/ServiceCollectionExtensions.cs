using Absoluta.Pagamentos.DataAccess.Repositorios;
using Absoluta.Pagamentos.Domain.RepoInterfaces;

namespace Absoluta.Pagamentos.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterDependencies(this IServiceCollection services)
    {
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IMensalidadeRepository, MensalidadeRepository>();

        return services;
    }
}
