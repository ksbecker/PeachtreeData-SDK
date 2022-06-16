using Newtonsoft.Json;

namespace PeachtreeData.Sdk.Models;

public class CassRequest
{
    [JsonProperty(PropertyName = "companyname")]
    public string? CompanyName { get; set; }

    [JsonProperty(PropertyName = "address1")]
    public string Address1 { get; set; } = default!;

    [JsonProperty(PropertyName = "address2")]
    public string? Address2 { get; set; }

    [JsonProperty(PropertyName = "city")]
    public string City { get; set; } = default!;

    [JsonProperty(PropertyName = "state")]
    public string State { get; set; } = default!;

    [JsonProperty(PropertyName = "zipcode")]
    public string Zip { get; set; } = default!;

    [JsonProperty(PropertyName = "requestId")]
    public string RequestId { get; set; } = default!;
}
