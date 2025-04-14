using BlazorCv.DataTransfer;
using Microsoft.AspNetCore.Components;

namespace BlazorCv.Components.Pages.Cv.ProjectEntry;

public partial class ProjectEntry : ComponentBase
{
	[Parameter]
	public required Project Project { get; set; }
}

