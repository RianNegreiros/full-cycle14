using Newtonsoft.Json;

namespace DotNetApi.WebSockets;
public class NewPointsPayload
{
    [JsonProperty("route_id")]
    public string RouteId { get; set; }
    public float Lat { get; set; }
    public float Lng { get; set; }
}
