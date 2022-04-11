using System.Net.Http.Json;
using System.Text.Json.Serialization;

HttpClient? httpClient = new();

HttpRequestMessage? request = new(HttpMethod.Get, "https://rickies.co/api/chairmen.json");
using HttpResponseMessage? httpResponse = await httpClient.SendAsync(request);

ChairmanResponse? results = await httpResponse.Content.ReadFromJsonAsync<ChairmanResponse?>();

Console.WriteLine($"Keynote Chairman: {results?.KeynoteChairman}");
Console.WriteLine($"Annual Chairman: {results?.AnnualChairman}");

[JsonSerializable(typeof(ChairmanResponse))]
public class ChairmanResponse
{
    [JsonPropertyName("keynote_chairman")]
    public Chairman? KeynoteChairman { get; set; }

    [JsonPropertyName("annual_chairman")]
    public Chairman? AnnualChairman { get; set; }
}

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

    public override string ToString()
    {
        return $"{Name} {LastName}";
    }
}
