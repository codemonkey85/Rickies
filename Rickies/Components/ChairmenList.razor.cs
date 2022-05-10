namespace Rickies.Components;

public partial class ChairmenList
{
    private ChairmanResponse? ChairmanResponse { get; set; }

    protected override async Task OnInitializedAsync() =>
        ChairmanResponse = await RickiesApiService.GetChairmen();
}
