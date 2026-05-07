# ServiceConnect - Professional Home Services Platform

ServiceConnect is a comprehensive ASP.NET Core MVC web application designed to connect homeowners with local service professionals like Carpenters, Electricians, and Plumbers.

## Features

- **Role-Based Access Control**:
  - **Customers**: Browse services, book providers, and track request status.
  - **Service Providers**: Manage job requests, update profile, and track status.
  - **Admin**: Full control over customers and providers.
- **Service Booking System**: Seamless flow for customers to request visits.
- **Interactive Dashboards**: Personalized views for all user roles.
- **MySQL Integration**: Persistent data storage using Entity Framework Core.
- **Modern UI**: Built with Tailwind CSS and Material Symbols for a premium look.

## Tech Stack

- **Framework**: ASP.NET Core 8.0 (MVC)
- **Database**: MySQL
- **ORM**: Entity Framework Core
- **Frontend**: Razor Views, Tailwind CSS, Material Symbols

## Admin Credentials

- **Email**: `hardik@gmail.com`
- **Password**: `12345678`

## Setup Instructions

1. **Database Configuration**:
   - Update the connection string in `appsettings.json` with your MySQL server details.
   - Run the following commands to create the database:
     ```bash
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

2. **Run the Application**:
   - Use Visual Studio or the .NET CLI:
     ```bash
     dotnet run
     ```

## Project Documentation

A detailed explanation of the project structure and files can be found in `ProjectStructure.txt`.
