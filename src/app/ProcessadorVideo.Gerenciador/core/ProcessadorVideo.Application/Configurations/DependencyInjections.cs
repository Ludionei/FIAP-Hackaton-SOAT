using Microsoft.Extensions.DependencyInjection;
using ProcessadorVideo.Application.UseCases;

namespace ProcessadorVideo.Application.Configurations;

public static class DependencyInjections
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IConverterVideoParaImagemUseCase, ConverterVideoParaImagemUseCase>();
        services.AddScoped<IListarProcessamentoUseCase, ListarProcessamentoUseCase>();
        services.AddScoped<IConsultarArquivoZipUseCase, ConsultarArquivoZipUseCase>();

        return services;
    }
}
