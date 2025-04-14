namespace BlazorCv.DataTransfer;

public record EmploymentRecord(
	string Position,
	string Company,
	DateOnly StartDate,
	DateOnly? EndDate,
	string[] Responsibilities);
