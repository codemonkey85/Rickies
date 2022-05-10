using System.Net.Http.Json;
using Rickies.Models;

HttpClient? httpClient = new();

HttpRequestMessage? request = new(HttpMethod.Get, "https://rickies.co/api/chairmen.json");
using var httpResponse = await httpClient.SendAsync(request);

var results = await httpResponse.Content.ReadFromJsonAsync<ChairmanResponse?>();

Console.WriteLine($"Keynote Chairman: {results?.KeynoteChairman}");
Console.WriteLine($"Annual Chairman: {results?.AnnualChairman}");
