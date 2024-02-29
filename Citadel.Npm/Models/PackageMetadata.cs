using System.Text.Json.Serialization;

namespace Npm.Models;

public class PackageMetadata
{
    public required string name { get; set; }
    
    [JsonPropertyName("dist-tags")]
    public Dictionary<string, string>? dist_tags { get; set; }
    
    public required Dictionary<string, PackageVersionMetadata>? versions { get; set; }
    
    public DateTime modified { get; set; }
}