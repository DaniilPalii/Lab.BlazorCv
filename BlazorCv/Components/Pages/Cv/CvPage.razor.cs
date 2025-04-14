using BlazorCv.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorCv.Components.Pages.Cv;

public partial class CvPage
{
	[Inject]
	protected ICvService CvService { get; set; } = null!;

	protected override async Task OnInitializedAsync()
	{
		cv = await CvService.GetAsync();
	}

	private DataTransfer.Cv? cv;
}
