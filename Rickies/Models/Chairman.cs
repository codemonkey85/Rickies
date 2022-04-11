namespace Rickies.Models;

[JsonSerializable(typeof(Chairman))]
public class Chairman
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("twitter")]
    public string? Twitter { get; set; }

    [JsonPropertyName("memoji")]
    public string? Memoji { get; set; }

    public string? FullName => $"{Name} {LastName}";

    public override string ToString() => FullName ?? base.ToString();
}
