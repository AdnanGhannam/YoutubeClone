using Microsoft.AspNetCore.Components;

namespace Youtube.Shared;

public class AppComponent : ComponentBase
{
    [Parameter]
    public virtual string Class { get; set; } = "";

    [Parameter]
    public virtual string Style { get; set; } = "";

    [Parameter]
    public virtual RenderFragment ChildContent { get; set; }
}
