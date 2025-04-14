namespace BlazorCv.DataTransfer;

public record Cv(
	string Title,
	string Name,
	string Address,
	string? Phone,
	string Email,
	string? GithubLink,
	string? LinkedInLink,
	string Summary,
	string[] Skills,
	Language[] Languages,
	EmploymentRecord[] EmploymentHistory,
	EducationRecord[] EducationHistory,
	Project[] CommercialProjects,
	Project[] PersonalProjects,
	string Clause);
