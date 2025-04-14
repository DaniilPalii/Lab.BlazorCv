using Microsoft.AspNetCore.Components;

namespace BlazorCv.Components.Pages.Cv.InfoRowLink;

public partial class InfoRowLink : ComponentBase
{
	[Parameter]
	public string Label { get; set; } = string.Empty;

	[Parameter]
	public string? Value { get; set; }

	[Parameter]
	public bool IsEmail { get; set; }
}

