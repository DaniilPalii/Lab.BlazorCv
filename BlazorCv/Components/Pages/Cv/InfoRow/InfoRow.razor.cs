using Microsoft.AspNetCore.Components;

namespace BlazorCv.Components.Pages.Cv.InfoRow;

public partial class InfoRow : ComponentBase
{
	[Parameter]
	public string Label { get; set; } = string.Empty;

	[Parameter]
	public string? Value { get; set; }
}

