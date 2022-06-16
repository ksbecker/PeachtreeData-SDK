
using PeachtreeData.Sdk.Models;

using Refit;

namespace PeachtreeData.Sdk;

public interface IPeachtreeDataApiClient
{
    [Post("/AddressCleanse")]
    Task<CassResponse> AddressCleanse([Body(true)] List<CassRequest> addresses, CancellationToken cancellationToken = default);
}
