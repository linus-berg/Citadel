namespace Npm.Models;

public class PackageVersionMetadata {
    public required string name { get; set; }
    public required string version { get; set; }
    public Dictionary<string, string>? dependencies { get; set; }
    public Dictionary<string, string>? peerDependencies { get; set; }
    public Dictionary<string, string>? devDependencies { get; set; }
    
    public Dictionary<string, string>? dist { get; set; }
}