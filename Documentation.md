Event Management System — .NET Project Documentation
📘 Table of Contents

1.Overview
2.Features
3.System Architecture
4.Technology Stack
5.Project Structure
6.Setup and Installation
7.Configuration
8.Running the Application
9.Future Enhancements
10.License

1. Overview

The Event Management System is a .NET Core web API that allows administrators to create and manage events, while users can browse, view details, and register for them.
Only users with the Admin role are authorized to add, update, or delete events.

This system ensures secure role-based access and supports integrations with web and mobile clients.

2. Features

✅ Admin-only Event Management – Only Admin users can create, edit, or delete events
✅ User Registration – Normal users can sign up and register for available events
✅ Event Browsing – All users can search and view public events
✅ JWT Authentication – Secure login and token-based authorization
✅ Logging and Exception Handling – Centralized error and log management
✅ Email Notifications (optional) – Registration confirmation emails
✅ RESTful API Endpoints – For frontend or mobile app integration

3. System Architecture
┌─────────────────────────────┐
│         Client UI           │
│ (React / Angular / Flutter) │
└────────────┬────────────────┘
             │
             ▼
┌─────────────────────────────┐
│   ASP.NET Core 8 Web API    │
│ ─ Authentication (JWT)      │
│ ─ Controllers (Admin, User) │
│ ─ Services (Business Logic) │
│ ─ Repository (Data Access)  │
└────────────┬────────────────┘
             │
┌────────────▼───────────────┐
│        SQL Server DB       │
│   Events, Users, Roles     │
└────────────────────────────┘

4. Technology Stack
Backend	ASP.NET Core 8.0
Database	PostgresSQL 
ORM	Entity Framework Core

5. Project Structure
EventManagement/
│
├── EventManagement.API/
│   ├── Controllers/
│   │   ├── EventsController.cs
│   ├── Models/
│   │   ├── Event.cs
│   │   ├── Venue.cs
│   │   └── ApplicationDbContext.cs
│   ├── Program.cs
│   └── appsettings.json

7. Setup and Installation
Prerequisites

.NET SDK 8.0+

SQL Server or Azure SQL

Visual Studio / VS Code

Postman (for API testing)

Steps

Clone the repository:

git clone https://github.com/Sarbojit482/Event-Management.git
cd Event-Management


Update the connection string in appsettings.json:

"ConnectionStrings": {
   "DefaultConnection": "Host=localhost;Port=5432;Database=event_management_db;Username=postgres;Password=Password"
}


Run migrations:

dotnet ef database update


Build and run:

dotnet run --project EventManagement.API

8. Configuration
appsettings.json Example:
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=event_management_db;Username=postgres;Password=Password"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}


9. Running the Application

After starting, the API will be available at:
👉 https://localhost:5001/swagger


17. Future Enhancements

Event categories and tags

Payment integration for tickets

Admin dashboard with charts

QR-code-based ticket verification

Notifications (SMS / Email reminders)

18. License

This project is licensed under the MIT License.