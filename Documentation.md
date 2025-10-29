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

✅ Email Notifications (optional) – Registration confirmation emails


3. System Architecture
   
<img width="288" height="443" alt="Screenshot 2025-10-29 210627" src="https://github.com/user-attachments/assets/89e34f41-af52-4b2f-9882-6c6f6f3c9072" />


4. Technology Stack
   
Backend	ASP.NET Core 8.0

Database	PostgresSQL 

ORM	Entity Framework Core

5. Project Structure
<img width="305" height="289" alt="Screenshot 2025-10-29 210733" src="https://github.com/user-attachments/assets/afc67971-9c2a-4b2e-9149-4027ffdc5beb" />

6. Setup and Installation
   
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

7. Configuration
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


9. Future Enhancements

Event categories and tags

Payment integration for tickets

Admin dashboard with charts

QR-code-based ticket verification

Notifications (SMS / Email reminders)

10. License


This project is licensed under the Apache 2.0 License.


