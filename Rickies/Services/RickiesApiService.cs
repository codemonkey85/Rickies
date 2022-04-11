namespace Rickies.Services;

public class RickiesApiService
{
    private readonly HttpClient _httpClient;

    public RickiesApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ChairmanResponse?> GetChairmen()
    {
        HttpRequestMessage? request = new(HttpMethod.Get, "https://rickies.co/api/chairmen.json");
        using HttpResponseMessage? httpResponse = await _httpClient.SendAsync(request);

        string? test = await httpResponse.Content.ReadAsStringAsync();

        ChairmanResponse? results = await httpResponse.Content.ReadFromJsonAsync<ChairmanResponse?>();
        return results;
    }
}
