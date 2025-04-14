using BlazorCv.DataTransfer;

namespace BlazorCv.Services;

public class MockCvService : ICvService
{
	public Task<Cv> GetAsync()
	{
		var cv = new Cv(
            Title: ".NET Developer",
            Name: "Daniil Palii",
            Address: "Lublin, Poland",
            Phone: null,
            Email: "Daniil.Palii@proton.me",
            GithubLink: "https://github.com/DaniilPalii",
            LinkedInLink: "https://linkedin.com/in/DaniilPalii",
            Summary:
				"I'm a .NET developer with over 6 years of experience."
					+ " I've completed more than 10 commercial projects, working in both international and Polish teams."
					+ " I specialize in building robust web applications"
					+ " — from back-end development using ASP.NET Web API to front-end with Angular and Blazor."
					+ " I'm open to learning new technologies and solving complex problems."
					+ " I'm looking for a full-time position in Lublin (on-site) or remotely, based on an employment contract.",
            Skills:
            [
	            "C#, .NET 9, .NET Core, .NET Framework",
                "ASP.NET Web API, ASP.NET MVC, Entity Framework Core, NHibernate, SQL, MS SQL Server, PostgreSQL, SQLite",
                "MAUI, WPF, Windows Forms, Angular 19, Blazor, HTML, CSS, JavaScript, TypeScript",
                "Kendo UI, MudBlazor UI, DevExpress, PrimeNG",
                "NUnit, Moq, NSubstitute, RhinoMocks, Jasmine, Selenium Web Driver, BUnit, SpecFlow",
                "WCF, gRPC, ClosedXML, Math.NET, Swagger, Scalar, Hangfire, MediatR",
                "Git, Docker, PowerShell",
                "Visual Studio, Visual Studio Code, Rider, IntelliJ, WebStorm",
                "CI Jenkins, Azure DevOps, GitHub Actions",
                "Clean code, design patterns, SOLID, DRY, KISS, REST, CQRS, REPR, DDD, TDD",
                "SCRUM, Jira, Confluence, Notion, GTD",
                "Basic knowledge of: Azure, Avalonia UI, Odata, Liquibase, ML.NET, Autofac, Ionic, Electron.js, Java 17, C++, Unity 3D"
            ],
            Languages:
            [
	            new Language(Title: "English", KnowledgeLevel: "B2"),
                new Language(Title: "Polish", KnowledgeLevel: "C2 (certified)"),
                new Language(Title: "Ukrainian", KnowledgeLevel: "Native"),
                new Language(Title: "Russian", KnowledgeLevel: "Native")
            ],
            EmploymentHistory:
            [
	            new EmploymentRecord(
		            Position: "Developer",
		            Company: "Cinkciarz.pl Sp. z o.o.",
		            StartDate: new DateOnly(year: 2024, month: 10, day: 1),
		            EndDate: new DateOnly(year: 2024, month: 12, day: 31),
                    Responsibilities:
                    [
	                    "Developing and supporting AML system.",
	                    "Writing unit tests and performing manual tests.",
	                    "Making code review."
		            ]),
                new EmploymentRecord(
	                Position: "Developer",
	                Company: "Transition Technologies-Software Sp. z o.o. / Transition Technologies S.A.",
	                StartDate: new DateOnly(year: 2018, month: 4, day: 1),
	                EndDate: new DateOnly(year: 2024, month: 9, day: 30),
                    Responsibilities:
                    [
	                    "Developing applications.",
	                    "Writing unit tests, integration tests and end-to-end tests.",
	                    "Refactoring code according to best practices and situation.",
	                    "Making code review.",
	                    "Optimizing critical parts of the application.",
	                    "Cooperating with Product Owner or client in field of tasks definition and evaluation.",
	                    "Discussing with Product Owner and the team about approaches, limitations and possible solution"
							+ " of given problems with taking into account budget.",
	                    "Writing documentation and presenting software to clients."
                    ]),
                new EmploymentRecord(
	                Position: "Apprentice",
	                Company: "R-Soft Studio Sp. z o.o.",
	                StartDate: new DateOnly(year: 2018, month: 2, day: 1),
	                EndDate: new DateOnly(year: 2018, month: 3, day: 31),
                    Responsibilities:
                    [
	                    "Developed android application.",
	                    "Learned how to work in team and use Git."
                    ])
            ],
            EducationHistory:
            [
	            new EducationRecord(
		            Institution: "University College of Enterprise and Administration in Lublin",
		            Degree: "Bachelor’s degree",
		            FieldOfStudy: "Computer Science",
		            StartDate: new DateOnly(year: 2015, month: 1, day: 1),
		            EndDate: new DateOnly(year: 2024, month: 12, day: 31))
            ],
            CommercialProjects: GetCommercialProjects(),
            PersonalProjects: GetPersonalProjects(),
            Clause:
				"I agree to the processing of personal data provided in this document for realizing the recruitment"
					+ " process pursuant to the Personal Data Protection Act of 10 May 2018 (Journal of Laws 2018, item 1000)"
					+ " and in agreement with Regulation (EU) 2016/679 of the European Parliament and of the Council of 27 April 2016"
					+ " on the protection of natural persons with regard to the processing of personal data and on"
					+ " the free movement of such data, and repealing Directive 95/46/EC (General Data Protection Regulation)."
        );

        return Task.FromResult(result: cv);
	}

	private static Project[] GetCommercialProjects() =>
	[
		new Project(
            Title: "AML system",
            Description:
				"ASP.NET Web API microservices and Windows Forms application that interacts with microservices."
					+ " I migrated microservices from .NET Core 2.2 and .NET 6 to .NET 8."
                    + " Made regression tests. Debugged and fixed bugs. Made code review.",
            TechnologiesUsed: [".NET Core 2.2", ".NET 6", ".NET 8", "Windows Forms", "PostgreSQL", "Liquibase", "MediatR", "DevExpress"],
            StartDate: new DateOnly(year: 2024, month: 10, day: 1),
            EndDate: new DateOnly(year: 2024, month: 12, day: 31)
        ),
        new Project(
            Title: "Desktop tools for Sage",
            Description:
				"Desktop applications (WPF, Windows Forms) to execute and schedule actions on Sage accounting database."
					+ " I migrated applications from .NET Framework 4.8 to .NET 8. "
					+ "Refactored code. Combined multiple apps into one WPF. Added GUI configuration. Optimized async code.",
            TechnologiesUsed:
            [".NET Framework 4.8", ".NET 8", "WPF", "Windows Forms", "Sage SDK", "Hangfire"],
            StartDate: new DateOnly(year: 2024, month: 8, day: 1),
            EndDate: new DateOnly(year: 2024, month: 9, day: 30)
        ),
        new Project(
            Title: "Food ordering service",
            Description:
				"Mobile and web applications servicing school food ordering. "
					+ "I fixed bugs and refactored code across mobile, web GUI, and web API.",
            TechnologiesUsed:
            [
	            ".NET 6", "C#", "ASP.NET Web API", "Entity Framework Core", "MS SQL Server", "Angular 7", "Hangfire",
	            "Docker", "Swagger"
            ],
            StartDate: new DateOnly(year: 2024, month: 7, day: 1),
            EndDate: new DateOnly(year: 2024, month: 8, day: 31)
        ),
        new Project(
            Title: "Statistical analysis tool",
            Description:
				"Web app (Blazor) and API (.NET 8) for statistical data analysis from spreadsheets. "
					+ "I developed the application from scratch, defined requirements with client, wrote docs, and demoed.",
            TechnologiesUsed:
            [
	            ".NET 8", "C#", "ASP.NET Web API", "Entity Framework Core", "MS SQL Server", "Blazor", "MudBlazor UI",
	            "NUnit", "ClosedXML", "Math.NET", "PowerShell", "Swagger"
            ],
            StartDate: new DateOnly(year: 2023, month: 12, day: 1),
            EndDate: new DateOnly(year: 2024, month: 6, day: 30)
        ),
        new Project(
            Title: "Credential system",
            Description:
				"Privileged account and credential management system. "
				+ "I improved existing code, upgraded internal SSH libraries, and coordinated changes in .NET, PowerShell, C++, and Python.",
            TechnologiesUsed:
            [
	            ".NET Framework 4.5", ".NET Framework 4.8", ".NET 5", "C#", "C++", "Python", "NUnit", "SpecFlow", "SSH",
	            "Artifactory", "Conan", "Jenkins", "PowerShell"
            ],
            StartDate: new DateOnly(year: 2022, month: 3, day: 1),
            EndDate: new DateOnly(year: 2023, month: 11, day: 30)
        ),
        new Project(
            Title: "Assets maintenance tool",
            Description: "Web app for monitoring and scheduling asset maintenance. I developed backend and frontend (Blazor), defined requirements with client in English.",
            TechnologiesUsed:
            [
	            ".NET 5", "ASP.NET Core Web API", "Entity Framework Core", "MS SQL Server", "Blazor WebAssembly",
	            "MudBlazor UI", "CSS 3", "NUnit", "BUnit", "Moq", "Azure", "Docker"
            ],
            StartDate: new DateOnly(year: 2022, month: 4, day: 1),
            EndDate: new DateOnly(year: 2022, month: 10, day: 31)
        ),
        new Project(
            Title: "Odata REST API",
            Description: "Odata REST API for product quality management prototype. I migrated API code to use Odata.",
            TechnologiesUsed: [".NET Framework 4.8", "ASP.NET Web API Odata", "Autofac", "NUnit", "Moq"],
            StartDate: new DateOnly(year: 2021, month: 12, day: 1),
            EndDate: new DateOnly(year: 2022, month: 3, day: 31)
        ),
        new Project(
            Title: "vSMS",
            Description: "Virtual Storage Management System optimizing gas distribution. I worked on backend and Angular frontend, participated in planning and grooming.",
            TechnologiesUsed:
            [
	            ".NET Core", "ASP.NET Core", "MS SQL Server", "NHibernate", "FluentNHibernate", "FluentMigrator",
	            "Angular 8", "Kendo UI", "NUnit", "Moq", "Jasmine", "gRPC"
            ],
            StartDate: new DateOnly(year: 2020, month: 6, day: 1),
            EndDate: new DateOnly(year: 2021, month: 11, day: 30)
        ),
        new Project(
            Title: "SOE",
            Description: "Storage Operation Expert — optimizing underground gas storage. I contributed to backend and frontend, participated in team planning.",
            TechnologiesUsed:
            [
	            ".NET Framework 4.8", "ASP.NET Web API", "MS SQL Server", "NHibernate", "FluentNHibernate",
	            "FluentMigrator", "Angular 5", "Kendo UI", "NUnit", "Moq", "Jasmine", "WCF"
            ],
            StartDate: new DateOnly(year: 2019, month: 4, day: 1),
            EndDate: new DateOnly(year: 2020, month: 10, day: 31)
        ),
        new Project(
            Title: "AGFS",
            Description: "Above Ground Facility Simulator — simulates state of gas installation. I developed backend and frontend features.",
            TechnologiesUsed:
            [
	            ".NET Framework 4.8", "ASP.NET Web API", "MS SQL Server", "NHibernate", "FluentNHibernate",
	            "FluentMigrator", "Angular 5", "Kendo UI", "NUnit", "Moq", "Jasmine"
            ],
            StartDate: new DateOnly(year: 2018, month: 12, day: 1),
            EndDate: new DateOnly(year: 2019, month: 9, day: 30)
        ),
        new Project(
            Title: "PDMS",
            Description: "Process Data Management System — measurement data and gas distribution. I improved backend/frontend in a Backbone.js app.",
            TechnologiesUsed:
            [
	            ".NET Framework 4.8", "ASP.NET MVC", "MS SQL Server", "NHibernate", "FluentNHibernate",
	            "FluentMigrator", "Backbone.js", "Kendo UI", "HTML", "CSS 3", "JQuery", "JavaScript", "NUnit",
	            "RhinoMock"
            ],
            StartDate: new DateOnly(year: 2018, month: 4, day: 1),
            EndDate: new DateOnly(year: 2018, month: 11, day: 30)
        ),
        new Project(
            Title: "Tourist information Android app",
            Description: "Android app for tourist locations and navigation. I contributed a module under senior guidance.",
            TechnologiesUsed: ["Android", "Java 8", "Retrofit", "Glide"],
            StartDate: new DateOnly(year: 2018, month: 2, day: 1),
            EndDate: new DateOnly(year: 2018, month: 3, day: 31)
        )
	];

    public static Project[] GetPersonalProjects() =>
    [
	    new Project(
            Title: "Goals and Tasks",
            Description: "Web API and web application for managing personal tasks. Continuously deployed to Azure Web Apps via GitHub Actions pipeline.",
            TechnologiesUsed:
            [
	            ".NET 9", "ASP.NET Web API", "Entity Framework Core", "MS SQL Server", "Scalar", "Angular 19", "PrimeNG",
	            "Azure Web Apps", "Azure SQL Database", "GitHub Actions",
            ],
            StartDate: new DateOnly(year: 2024, month: 12, day: 1),
            EndDate: new DateOnly(year: 2025, month: 1, day: 31)
        ),
        new Project(
            Title: "AML Web API",
            Description: "Web API for anti-laundering system using CQRS. Stores transaction data and runs scheduled verifications.",
            TechnologiesUsed: [".NET 8", "ASP.NET Web API", "Entity Framework Core", "Hangfire", "MediatR"],
            StartDate: new DateOnly(year: 2024, month: 8, day: 1),
            EndDate: new DateOnly(year: 2024, month: 9, day: 30)
        ),
        new Project(
            Title: "Data Peersync",
            Description: "Cross-platform peer-to-peer file sync in local network, with versions for Windows and Android.",
            TechnologiesUsed: [".NET 8", "Avalonia UI", "MAUI", "SQLite"],
            StartDate: new DateOnly(year: 2024, month: 5, day: 1),
            EndDate: new DateOnly(year: 2024, month: 6, day: 30)
        )
    ];
}
