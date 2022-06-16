using Microsoft.Extensions.DependencyInjection;

using Refit;

namespace PeachtreeData.Sdk;

public static class ServiceCollectionExtensions
{
    public static IHttpClientBuilder AddPeachtreeDataApiClient(this IServiceCollection services, Action<HttpClient> configureClient)
    {
        var settings = new RefitSettings(new NewtonsoftJsonContentSerializer());

        return services.AddRefitClient<IPeachtreeDataApiClient>(settings)
        .ConfigureHttpClient((httpClient) =>
         {
             PeachtreeDataClientFactory.ConfigureHttpClientCore(httpClient);
             configureClient(httpClient);
         });
    }
}
