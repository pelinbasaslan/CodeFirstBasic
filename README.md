# Code First Approach with Entity Framework Core

This project demonstrates how to create a database using the Code First approach with Entity Framework Core.

## Database Schema
The database consists of two independent tables:

### Movie Table
- **Id**: int, primary key, auto-increment
- **Title**: string, movie title
- **Genre**: string, movie genre (e.g., "Action", "Comedy", "Drama")
- **ReleaseYear**: int, release year of the movie

### Game Table
- **Id**: int, primary key, auto-increment
- **Name**: string, game name
- **Platform**: string, game platform (e.g., "PC", "PlayStation", "Xbox")
- **Rating**: decimal, game rating (between 0 and 10)

## Database Context
- **Context Class Name**: `PatikaFirstDbContext`
- **Database Name**: `PatikaCodeFirstDb1`
- **Tables**: `Movies`, `Games`

## Setup Instructions

### Prerequisites
- .NET SDK 8 or later
- PostgreSQL database
- Visual Studio Code or any preferred IDE

### Install Required Packages
Run the following commands to install necessary NuGet packages:
```sh
 dotnet add package Microsoft.EntityFrameworkCore --version "8.*"
 dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version "8.*"
 dotnet add package Microsoft.EntityFrameworkCore.Design
```

### Database Migration
Run the following commands to create and apply migrations:
```sh
 dotnet ef migrations add InitialCreate
 dotnet ef database update
```

### Running the Application
Use the following command to run the application:
```sh
 dotnet run
```

## Project Structure
```
📂 ProjectRoot
 ├── 📂 Context
 │   ├── PatikaFirstDbContext.cs
 ├── 📂 Models
 │   ├── Movie.cs
 │   ├── Game.cs
 ├── 📂 Migrations
 ├── 📂 Controllers
 ├── 📂 Program.cs
 ├── 📜 appsettings.json
 ├── 📜 README.md
```

## Notes
- Ensure that your PostgreSQL connection string is correctly set in `appsettings.json` under `ConnectionStrings`.
- Use `dotnet ef migrations add <MigrationName>` to create new migrations when modifying the models.
- Use `dotnet ef database update` to apply migrations to the database.


