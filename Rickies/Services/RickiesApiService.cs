namespace Rickies.Services;

public class RickiesApiService
{
    private readonly HttpClient _httpClient;

    public RickiesApiService(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<ChairmanResponse?> GetChairmen() => await _httpClient.GetFromJsonAsync<ChairmanResponse?>("sample-data/chairmen.json");
}
