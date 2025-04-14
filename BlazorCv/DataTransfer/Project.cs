namespace BlazorCv.DataTransfer;

public record Project(
	string Title,
	string Description,
	string[] TechnologiesUsed,
	DateOnly StartDate,
	DateOnly? EndDate);
