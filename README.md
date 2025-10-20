# Event Management System
## Descriptiom
The **Event management system** is a web application built using **asp.net core MVC** and **Entity Framework Core**.
It allows User to create,view,edit and delete events, and manage venue effficiently.
This project follows a clean service-based architecture and uses Postgres for data Storage.

## Installation Steps
### 1 Prerequisites
Before we begin, we need to make sure we have installed:
- .NET SDK 8.0+
- Postgres
### 2 Clone the Repository 
Open terminal and run
git clone hhtps://github.com/Sarbojit482/Event-Management
cd Event-Management
or just create a mvc using dotnet new mvc (project name) and just copy the required files form the repo to the project

### 3 Configuration database
"ConnectionString":{
"DefaultConnection": "Host=localhost;Database=EventmanagementDB;Username=postgres;Password=yourpassword"}

### 4 Apply Database Migrations
dotnet ef database update

### To Run the projects
1.Open VS code or visual studio

2.dotnet run

3.open your browser and go to : https://localhost:"the port given"


## Screenshots
### Event list
<img width="1615" height="445" alt="Screenshot 2025-10-20 215322" src="https://github.com/user-attachments/assets/4d58a0ac-61b0-4c33-9e86-6a82b50a253f" />

### Create events 
<img width="1597" height="765" alt="Screenshot 2025-10-20 215340" src="https://github.com/user-attachments/assets/674c786c-5534-4faa-bc68-23c05ad079d2" />


