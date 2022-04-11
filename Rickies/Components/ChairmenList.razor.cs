namespace Rickies.Components;

public partial class ChairmenList
{
    private readonly IList<Chairman> chairmanList = new List<Chairman>();

    protected override async Task OnInitializedAsync()
    {
        ChairmanResponse? chairmanResponse = await RickiesApiService.GetChairmen();
        if (chairmanResponse is null)
        {
            return;
        }
        if (chairmanResponse.KeynoteChairman is not null)
        {
            chairmanList.Add(chairmanResponse.KeynoteChairman);
        }
        if (chairmanResponse.AnnualChairman is not null)
        {
            chairmanList.Add(chairmanResponse.AnnualChairman);
        }
    }
}
