namespace Rickies.Models;

[JsonSerializable(typeof(ChairmanResponse))]
public class ChairmanResponse
{
    [JsonPropertyName("keynote_chairman")]
    public Chairman? KeynoteChairman { get; set; }

    [JsonPropertyName("annual_chairman")]
    public Chairman? AnnualChairman { get; set; }
}
