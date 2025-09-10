# MunicipalityApp
Project Overview

The Municipality Issue Reporting System is a C# Windows Forms application designed to allow residents to report issues within their local municipality. This system aims to streamline communication between citizens and municipal authorities by providing a user-friendly interface for submitting issues, attaching relevant files, and viewing reports.
Currently, the system implements the Report Issues functionality, with placeholders for Local Events & Announcements and Service Request Status, which can be extended in future versions.

## Key Features
Main Menu

Provides three options:
Report Issues – implemented.
Local Events & Announcements – disabled for now.
Service Request Status – disabled for now.
Optional button: View Reports – for municipal staff to view all submitted issues.

Report Issues Form
Location Input: Enter the location of the reported issue.
Category Selection: Select a category (Sanitation, Roads, Utilities).
Description Box: Provide a detailed description of the issue.
Attach File: Option to attach images or documents.
Submit Button: Save the report with timestamp.
Engagement Feature: A progress bar and status label display submission progress and success messages.
Back Button: Navigate back to Main Menu.
View Reports Form
Displays all submitted reports in a DataGridView.
Columns include: Location, Category, Description, Attachment, ReportedAt.
Back button to return to Main Menu.

## Project Structure
MunicipalityApp/
│
├─ Data/
│   └─ IssueRepository.cs          # Manages storage and persistence
│
├─ Models/
│   └─ Issue.cs                    # Represents an issue entity
│
├─ MainMenuForm.cs
├─ MainMenuForm.Designer.cs
├─ ReportIssuesForm.cs
├─ ReportIssuesForm.Designer.cs
├─ ViewReportsForm.cs
├─ ViewReportsForm.Designer.cs
└─ Program.cs

## Data Handling & Persistence

Models/Issue.cs: Defines the Issue class, which stores:
Location
Category
Description
Attachment file path
Timestamp (ReportedAt)

Data/IssueRepository.cs:
Maintains a list of submitted issues.
Saves all reports to a issues.json file for persistent storage.
Loads existing reports on application startup.

Methods:
AddIssue(Issue issue) – Adds a new issue and updates issues.json.
LoadIssues() – Loads previously saved issues.
File Attachments: Users can attach images or documents. The path is stored in the report.
Setup & Installation
Prerequisites
Visual Studio 2019 or later (Windows Forms App .NET Framework).
.NET Framework 8.0 (or compatible).

## Steps to Compile and Run
Open Visual Studio.
Create a new Windows Forms App (.NET Framework) project.
Copy all source code files into the project directory.
Ensure MainMenuForm is set as the startup form in Program.cs:
Application.Run(new MainMenuForm());
Build the project (Build → Build Solution).
Run the project (F5).

Data Persistence
Reports are saved to issues.json in the same directory as the executable.
The file is automatically created if it doesn’t exist.
All reports are loaded on application startup.

## How to Use the Application
Main Menu
1. Click Report Issues to submit a new issue.
2. Click View Reports to see all submitted issues (optional, for municipal staff).
Other options are placeholders for future features.
1.1Report Issues Form
1A. Enter the location of the issue.
1B. Select a category from the dropdown.
1C. Enter a detailed description.
1D. Optional: click Attach File to add images or documents.
1F. Click Submit to save the report.
The progress bar indicates submission status.
After submission, all fields are reset for a new report.
1G. Click Back to return to the main menu.

2.1 View Reports Form
See all submitted issues in a table.
Columns include Location, Category, Description, Attachment, and ReportedAt.
Click Back to return to Main Menu.
Optional: later, attachments can be opened directly, and reports filtered by category or date.

Future Enhancements
Enable Local Events & Announcements and Service Request Status.
Add filtering and search in View Reports (by date, category, or location).
Open attachments directly from the grid.
Integrate with a database (SQL Server) for scalable persistence.
Add user authentication for municipal staff and residents.

## Conclusion

This project provides a robust foundation for citizen engagement with municipal services. It demonstrates clean architecture with Models, Data Repository, and Windows Forms UI, making it easy to maintain, extend, and scale.
