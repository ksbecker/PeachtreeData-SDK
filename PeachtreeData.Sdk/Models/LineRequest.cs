using Newtonsoft.Json;

namespace PeachtreeData.Sdk.Models;

public class LineRequest
{
    [JsonProperty(PropertyName = "line1")]
    public string? Line1 { get; set; }

    [JsonProperty(PropertyName = "line2")]
    public string? Line2 { get; set; }

    [JsonProperty(PropertyName = "line3")]
    public string? Line3 { get; set; }

    [JsonProperty(PropertyName = "line4")]
    public string? Line4 { get; set; }

    [JsonProperty(PropertyName = "line5")]
    public string? Line5 { get; set; }

    [JsonProperty(PropertyName = "line6")]
    public string? Line6 { get; set; }

    [JsonProperty(PropertyName = "line7")]
    public string? Line7 { get; set; }

    [JsonProperty(PropertyName = "line8")]
    public string? Line8 { get; set; }
}
