# Role-Based Authentication and Authorization System

This ASP.NET Core MVC application demonstrates a role-based authentication and authorization system using Identity Framework. The application implements three distinct roles (Admin, Moderator, and User) with different permission levels and access controls.

## Features

- User authentication (registration, login, logout)
- Role-based authorization
- Dynamic navigation based on user roles
- Role-specific dashboards
- SQLite database for data persistence

## Default Credentials

The system is pre-configured with the following default accounts for testing:

| Role      | Email                  | Password      |
|-----------|------------------------|---------------|
| Admin     | admin@example.com      | Admin@123     |
| Moderator | moderator@example.com  | Moderator@123 |
| User      | user@example.com       | User@123      |

## Implementation Scope

This project implements the authentication and authorization framework with placeholder UI elements for role-specific features. The actual functionality behind these UI elements is not implemented and would need to be developed for a production application.

### What IS Implemented:

- Complete authentication system
- Role-based access control
- Dynamic UI based on user roles
- Database schema with Identity tables

### What is NOT Implemented:

- Backend functionality for admin features (user/role management)
- Backend functionality for moderator features (content management)
- Backend functionality for user features (profile management)

## Prerequisites

- .NET 9.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

## Getting Started

1. Clone the repository
   ```
   git clone https://github.com/uzair958/Web_Programming_A4
   ```

2. Navigate to the project directory
   ```
   cd wp_A4
   ```

3. Restore dependencies
   ```
   dotnet restore
   ```

4. Run the application
   ```
   dotnet run
   ```

5. Open Browser through link

## Project Structure

- **Controllers/**
  - AccountController.cs - Handles user authentication
  - AdminController.cs - Admin-specific features
  - HomeController.cs - Public pages
  - ModeratorController.cs - Moderator-specific features
  - UserController.cs - User-specific features

- **Models/**
  - ApplicationUser.cs - Custom user model
  - ErrorViewModel.cs - Error handling

- **Data/**
  - ApplicationDbContext.cs - Database context

- **ViewModels/**
  - LoginViewModel.cs - Login form model
  - RegisterViewModel.cs - Registration form model

- **Views/**
  - Role-specific views and shared layouts

## Database

The application uses SQLite for data persistence. The database is automatically created on first run with the necessary tables for Identity Framework.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- ASP.NET Core team for the Identity Framework
- Microsoft documentation and tutorials
