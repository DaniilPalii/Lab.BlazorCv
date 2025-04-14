namespace BlazorCv.DataTransfer;

public record EducationRecord(
	string Institution,
	string Degree,
	string FieldOfStudy,
	DateOnly StartDate,
	DateOnly? EndDate);
