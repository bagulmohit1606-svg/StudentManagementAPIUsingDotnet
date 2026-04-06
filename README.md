Student Management System API

A Student Management System built using ASP.NET Core Web API with CRUD
operations, JWT Authentication, SQL Server integration, and layered
architecture.

Features: - Get all students - Add new student - Update student - Delete
student - JWT Authentication - Global Exception Handling - Logging with
Serilog - Swagger API Documentation

Setup Steps: 1. Clone repository 2. Configure database connection in
appsettings.json 3. Configure JWT settings 4. Run: dotnet ef database
update 5. Run: dotnet run 6. Open Swagger:
https://localhost:xxxx/swagger

Authentication: - POST /api/auth/login - Use: Username: admin Password:
1234 - Copy token and use: Authorization: Bearer

APIs: GET /api/student POST /api/student PUT /api/student DELETE
/api/student/{id}

Author: Mohit Bagul
