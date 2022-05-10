namespace Rickies.Components;

public partial class ChairmanComponent
{
    [Parameter, EditorRequired] public Chairman? Chairman { get; set; }

    [Parameter, EditorRequired] public string Title { get; set; } = string.Empty;
}
