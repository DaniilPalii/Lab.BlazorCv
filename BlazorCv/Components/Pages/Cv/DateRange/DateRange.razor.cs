using Microsoft.AspNetCore.Components;

namespace BlazorCv.Components.Pages.Cv.DateRange;

public partial class DateRange
{
	[Parameter]
	public DateOnly StartDate { get; set; } = default!;

	[Parameter]
	public DateOnly? EndDate { get; set; }

	[Parameter]
	public string Format { get; set; } = "yyyy-MM";
}
