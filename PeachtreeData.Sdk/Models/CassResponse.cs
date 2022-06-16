
using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace PeachtreeData.Sdk.Models;

public class CassResponse
{
    [JsonProperty(PropertyName = "totalRequests")]
    public int TotalRequests { get; set; }

    [JsonProperty(PropertyName = "totalProcessed")]
    public int TotalProcessed { get; set; }

    [JsonProperty(PropertyName = "totalInvalidRequests")]
    public int TotalInvalidRequests { get; set; }

    [JsonProperty(PropertyName = "totalError")]
    public int TotalError { get; set; }

    [JsonProperty(PropertyName = "responses")]
    public Response[] Responses { get; set; } = default!;
}

public class Response
{

    [JsonProperty(PropertyName = "components")]
    public Components? Components { get; set; }

    [JsonProperty(PropertyName = "metadata")]
    public Metadata? Metadata { get; set; }

    [JsonProperty(PropertyName = "geoCode")]
    public Geocode? GeoCode { get; set; }

    [JsonProperty(PropertyName = "fullAddress")]
    public string? FullAddress { get; set; }

    [JsonProperty(PropertyName = "primaryAddress")]
    public string? PrimaryAddress { get; set; }

    [JsonProperty(PropertyName = "secondaryAddress")]
    public string? SecondaryAddress { get; set; }

    [JsonProperty(PropertyName = "lastLine")]
    public string? LastLine { get; set; }

    [JsonProperty(PropertyName = "status")]
    public Status Status { get; set; } = default!;

    [JsonProperty(PropertyName = "statusMessage")]
    public string? StatusMessage { get; set; }

    [JsonProperty(PropertyName = "requestId")]
    public string RequestId { get; set; } = default!;
}

public class Components
{
    [JsonProperty(PropertyName = "primaryNumber")]
    public string PrimaryNumber { get; set; } = default!;

    [JsonProperty(PropertyName = "primaryPrefix")]
    public string PrimaryPrefix { get; set; } = default!;

    [JsonProperty(PropertyName = "primaryName")]
    public string PrimaryName { get; set; } = default!;

    [JsonProperty(PropertyName = "primaryType")]
    public string PrimaryType { get; set; } = default!;

    [JsonProperty(PropertyName = "primaryPostfix")]
    public string PrimaryPostfix { get; set; } = default!;

    [JsonProperty(PropertyName = "primaryAddressRemainder")]
    public string PrimaryAddressRemainder { get; set; } = default!;

    [JsonProperty(PropertyName = "secondaryUnitDescription")]
    public string SecondaryUnitDescription { get; set; } = default!;

    [JsonProperty(PropertyName = "secondaryUnitNumber")]
    public string SecondaryUnitNumber { get; set; } = default!;

    [JsonProperty(PropertyName = "secondaryAddressExtraneous")]
    public string SecondaryAddressExtraneous { get; set; } = default!;

    [JsonProperty(PropertyName = "city")]
    public string City { get; set; } = default!;

    [JsonProperty(PropertyName = "city13")]
    public string City13 { get; set; } = default!;

    [JsonProperty(PropertyName = "state")]
    public string State { get; set; } = default!;

    [JsonProperty(PropertyName = "zip10")]
    public string Zip10 { get; set; } = default!;

    [JsonProperty(PropertyName = "zip5")]
    public string Zip5 { get; set; } = default!;

    [JsonProperty(PropertyName = "zip4")]
    public string Zip4 { get; set; } = default!;

    [JsonProperty(PropertyName = "nonPostalSecondaryAddress")]
    public string NonPostalSecondaryAddress { get; set; } = default!;

    [JsonProperty(PropertyName = "extraLine1")]
    public string ExtraLine1 { get; set; } = default!;

    [JsonProperty(PropertyName = "extraLine2")]
    public string ExtraLine2 { get; set; } = default!;
}

public class Metadata
{
    [JsonProperty(PropertyName = "addressType")]
    public string AddressType { get; set; } = default!;

    [JsonProperty(PropertyName = "isDefault")]
    public bool IsDefault { get; set; }

    [JsonProperty(PropertyName = "countyCode")]
    public string CountyCode { get; set; } = default!;

    [JsonProperty(PropertyName = "countyName")]
    public string CountyName { get; set; } = default!;

    [JsonProperty(PropertyName = "dpvStatus")]
    public string DpvStatus { get; set; } = default!;

    [JsonProperty(PropertyName = "isVacant")]
    public bool? IsVacant { get; set; }

    [JsonProperty(PropertyName = "rawDetailCode")]
    public string RawDetailCode { get; set; } = default!;

    [JsonProperty(PropertyName = "deliveryPointBarCode")]
    public string DeliveryPointBarCode { get; set; } = default!;

    [JsonProperty(PropertyName = "deliveryPointBarCodeCheckDigit")]
    public string DeliveryPointBarCodeCheckDigit { get; set; } = default!;

    [JsonProperty(PropertyName = "lineOfTravel")]
    public string LineOfTravel { get; set; } = default!;

    [JsonProperty(PropertyName = "lineOfTravelOrder")]
    public string LineOfTravelOrder { get; set; } = default!;

    [JsonProperty(PropertyName = "carrierRoute")]
    public string CarrierRoute { get; set; } = default!;

    [JsonProperty(PropertyName = "dpvFootnote")]
    public string DpvFootnote { get; set; } = default!;

    [JsonProperty(PropertyName = "isDpvNoStat")]
    public bool? IsDpvNoStat { get; set; }

    [JsonProperty(PropertyName = "suiteLinkResult")]
    public string SuiteLinkResult { get; set; } = default!;

    [JsonProperty(PropertyName = "lacsLinkReturnCode")]
    public string LacsLinkReturnCode { get; set; } = default!;

    [JsonProperty(PropertyName = "rdi")]
    public string Rdi { get; set; } = default!;
}
public class Geocode
{

    [JsonProperty(PropertyName = "assignmentLevel")]
    public string AssignmentLevel { get; set; } = default!;

    [JsonProperty(PropertyName = "censusTractBlock")]
    public string CensusTractBlock { get; set; } = default!;

    [JsonProperty(PropertyName = "latitude")]
    public string Latitude { get; set; } = default!;

    [JsonProperty(PropertyName = "longitude")]
    public string Longitude { get; set; } = default!;

    [JsonProperty(PropertyName = "metroStatAreaCode")]
    public string MetroStatAreaCode { get; set; } = default!;
}

public enum Status
{
    [EnumMember(Value = "Confirmed")]
    Confirmed,
    [EnumMember(Value = "ConfirmedPrimaryUnavailableSecondary")]
    ConfirmedPrimaryUnavailableSecondary,
    [EnumMember(Value = "ConfirmedPrimaryInvalidSecondary")]
    ConfirmedPrimaryInvalidSecondary,
    [EnumMember(Value = "Invalid")]
    Invalid,
    [EnumMember(Value = "NotAttempted")]
    NotAttempted,
    [EnumMember(Value = "InvalidRequest")]
    InvalidRequest,
}