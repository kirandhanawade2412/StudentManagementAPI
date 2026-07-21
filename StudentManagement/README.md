# Student Management API

## Overview

This project is a Student Management System developed using ASP.NET Core Web API. It supports CRUD operations for student records with JWT Authentication, Entity Framework Core, SQL Server, Swagger documentation, and a layered architecture.

## Technologies Used

- ASP.NET Core 8 Web API
- C#
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger
- Serilog
- Repository Pattern
- Service Layer

## Features

- User Login using JWT
- Add Student
- Get All Students
- Get Student by Id
- Update Student
- Delete Student
- Global Exception Handling
- Logging with Serilog
- Swagger API Documentation

## Project Structure

```
Controllers
Data
DTOs
Interfaces
Middleware
Models
Repository
Services
```

## Setup Steps

### 1. Clone the Repository

```bash
git clone https://github.com/YourUsername/StudentManagementAPI.git
```

### 2. Open the Project

Open the solution in Visual Studio 2022.

### 3. Update Connection String

Edit `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=StudentManagementDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4. Restore Packages

```bash
dotnet restore
```

### 5. Create Database

```bash
Add-Migration InitialCreate
Update-Database
```

### 6. Run the Project

```bash
dotnet run
```

or press **F5** in Visual Studio.

### 7. Open Swagger

```
https://localhost:xxxx/swagger
```

### Login Credentials

```
Username: admin
Password: admin123
```

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | /api/Auth/login | Login |
| GET | /api/Student | Get All Students |
| GET | /api/Student/{id} | Get Student By Id |
| POST | /api/Student | Add Student |
| PUT | /api/Student/{id} | Update Student |
| DELETE | /api/Student/{id} | Delete Student |

## Author

Kiran Dhanawade