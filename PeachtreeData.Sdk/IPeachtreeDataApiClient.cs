
using PeachtreeData.Sdk.Models;

using Refit;

namespace PeachtreeData.Sdk;

public interface IPeachtreeDataApiClient
{
    [Post("/AddressCleanse")]
    Task<CassResponse> AddressCleanseAsync([Body(true)] List<AddressRequest> addresses, CancellationToken cancellationToken = default);

    [Post("/AddressCleanse")]
    Task<CassResponse> AddressCleanseAsync([Body(true)] List<LineRequest> addresses, CancellationToken cancellationToken = default);
}
