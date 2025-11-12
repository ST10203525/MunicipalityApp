# MunicipalityApp
Project Overview

The Municipality Issue Reporting System is a C# Windows Forms application designed to allow residents to report issues within their local municipality. This system aims to streamline communication between citizens and municipal authorities by providing a user-friendly interface for submitting issues, attaching relevant files, and viewing reports.
Currently, the system implements the Report Issues functionality, with placeholders for Local Events & Announcements and Service Request Status, which can be extended in future versions.

## Key Features
Main Menu

Provides three options:
Report Issues – implemented.
Local Events & Announcements – implemented in part 2
Service Request Status – implemented in part 3
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


# Municipal Services Application — Task 3  
**Module:** PROG7312
**Language:** C# (.NET Framework, Windows Forms)  
**Developer:** Kiyashan Nadasen  

---

## Overview  
The **Municipal Services Application** provides residents with an interactive platform to engage with their municipality. Users can:  
1. **Report Issues** (Task 1)  
2. **View Local Events and Announcements** (Task 2)  
3. **Track Service Request Status** (Task 3 — This task)  

This phase focuses on **data structure integration** to manage and display service request information efficiently using **Binary Trees**, **Heaps**, and **Graphs**.  

---

##  How to Compile and Run  

1. Open the project in **Visual Studio 2022 or newer**.  
2. Ensure the startup form is set to **MainMenuForm**.  
3. Press **F5** or click **Start** to run the application.  
4. On the main menu, select **“Service Request Status”**.  

---

##  Features  

### Service Request Status Form  
The form allows users to:  
- **Load** sample service requests.  
- **Search** for a service request using its **unique ID** (Binary Search Tree).  
- **View priority order** of requests (Min Heap).  
- **Visualize request relationships** and generate a **Minimum Spanning Tree (MST)** (Graph).  
- **Filter and sort** the last searched ID to appear **on top** for user convenience.  

---

## Data Structures Implemented  

###  1. Binary Search Tree (BST)
**Purpose:**  
Used to store and search for service requests efficiently based on their **Request ID**.  

**Implementation Details:**  
- Each node stores a `ServiceRequest` object.  
- Searching is **O(log n)** for balanced data.  
- The user’s last searched ID is moved to the top of the DataGridView using the BST search result.  

**Example:**  
```csharp
BinarySearchTree bst = new BinarySearchTree();
bst.Insert(new ServiceRequest("REQ001", "Pothole Repair", "Pending", 2));
var result = bst.Search("REQ001");
```
If found, the request is highlighted and displayed first.

---

###  2. Min Heap (Priority Queue)
**Purpose:**  
Manages service requests by **priority** — the lowest number has the highest urgency.  

**Implementation Details:**  
- Requests are inserted into a `MinHeap`.  
- The heap organizes data automatically, allowing quick extraction of the **highest-priority** request.  

**Example:**  
```csharp
MinHeap heap = new MinHeap();
heap.Insert(new ServiceRequest("REQ003", "Water Leak", "Resolved", 1));
heap.ExtractMin(); // Returns the most urgent request
```

---

### 3. Graph & Minimum Spanning Tree (MST)
**Purpose:**  
Represents relationships between requests (e.g., dependencies or route connections) and computes the **most efficient way** to manage or process them.  

**Implementation Details:**  
- Graph is represented with an **adjacency list**.  
- **Breadth-First Search (BFS)** traverses through all connected requests.  
- **Minimum Spanning Tree (MST)** finds the minimal connection paths using a variation of **Kruskal’s Algorithm**.  

**Example:**  
```csharp
Graph g = new Graph();
g.AddEdge("REQ001", "REQ002", 3);
var mst = g.MinimumSpanningTree();
```
This helps optimize relationships and dependencies between service requests.

---

## 🧠 Efficiency Contributions  

| Data Structure | Functionality | Benefit |
|----------------|----------------|----------|
| **Binary Search Tree** | Search & sort requests by ID | Fast lookup (O(log n)) |
| **Min Heap** | Prioritize service requests | Efficient extraction of highest priority |
| **Graph & MST** | Relationship mapping | Visualizes connections & minimizes total link cost |

---

## 🪄 User Flow  

1. **Launch the Application**  
   The main menu displays three options.  
2. **Select "Service Request Status"**  
   Opens a detailed form for viewing and managing requests.  
3. **Click “Load Sample Requests”**  
   Loads test data into a grid.  
4. **Search for a Request ID**  
   Displays details and filters the matching ID to the top.  
5. **View Priority Order**  
   Displays all requests sorted by urgency (Heap structure).  
6. **Graph Visualization**  
   Shows request traversal and MST information.  
7. **Return to Main Menu**  
   Click **Back** to navigate home.

---

## 🧾 Example Output  

**After Loading Data:**  
| Request ID | Description | Status | Priority |
|-------------|-------------|---------|-----------|
| REQ001 | Pothole Repair | Pending | 2 |
| REQ002 | Streetlight Fix | In Progress | 3 |
| REQ003 | Water Leak | Resolved | 1 |

**After Searching `REQ003`:**  
 “Water Leak” request moves to the top of the list.

---

##  Files Included  

| File | Description |
|------|-------------|
| `MainMenuForm.cs` | Main navigation screen |
| `ServiceRequestStatusForm.cs` | Core form handling BST, Heap, and Graph logic |
| `ServiceRequestStatusForm.Designer.cs` | UI layout and component initialization |
| `Program.cs` | Entry point of the application |

---

##  Future Enhancements  
- Connect data to a **database** for persistent storage.  
- Add **real-time updates** for request statuses.  
- Implement **Red-Black Trees** for self-balancing performance.  
- Display **graph visualization** on the UI instead of message boxes.

---

##  Conclusion  
This implementation demonstrates the power of **data structures** in optimizing real-world systems. The integration of **trees**, **heaps**, and **graphs** provides structure, performance, and reliability to the Service Request Status feature, transforming municipal data into an efficient and insightful management system.

