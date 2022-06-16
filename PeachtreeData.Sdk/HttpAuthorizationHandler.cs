using Microsoft.AspNetCore.WebUtilities;

namespace PeachtreeData.Sdk;

public class HttpAuthorizationHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Headers.Contains("ApiKey"))
        {
            var apiKey = request.Headers.First(h => h.Key == "ApiKey").Value.First()!;
            request.Headers.Remove("ApiKey");

            var newQueryString = QueryHelpers.AddQueryString(request.RequestUri!.Query, "apikey", apiKey);
            request.RequestUri = new Uri(request.RequestUri.Scheme + "://" + request.RequestUri.Host + request.RequestUri.AbsolutePath + newQueryString);
        }

        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

        return response;
    }
}
