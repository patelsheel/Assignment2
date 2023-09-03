# Assignment2
This README explains the development and documentation of the assignment 2. The project fulfills specific requirements and adheres to guidelines provided. 
## Project Structure

The project was structured as follows:

- **Project Name**: The ASP.NET Core Web API project was named "Assignment2"
- **Folders**: The project was organized into folders, including Controllers, Entities, and Data to maintain a structured and organized codebase.

## Database Setup

SQL Server Developer Edition was used as the database. The connection string in the `appsettings.json` file was re-configured to allow SQL Server to run on Azure Data Studio on a Mac.

## Entity Framework

Entity Framework was set up as follows:

- **Entities**: Two Entities, `Students` and `Professors`, were created with appropriate annotations to represent data entities.
- **DbContext**: A custom `AppDbContext` class was implemented, which included `DbSets` for the `User` and `Task` models. This DbContext was registered in the application's services and injected into controllers using dependency injection.
- **Migrations**: A migration was created and applied to update the database schema based on model changes.

## Controllers

Two controllers, `StudentsController` and `ProfessorsControllers`, were created, each implementing the standard HTTP methods:

- **GET**: Retrieve data from the database.
- **POST**: Add new data to the database.
- **PUT**: Update existing data in the database.
- **DELETE**: Remove data from the database.

The routes, model names, and controllers were named and structured following RESTful API conventions for clarity and consistency.

## Postman Testing

For testing the API, Postman was used as the testing tool. The following steps were taken:

1. Two Postman collections named `Assignment2-Students` and `Assignment2-Professors` was created.
2. Within the collections, requests for each HTTP method (GET, POST, PUT, DELETE) were added.
3. Each request was documented.
4. Execution of each request in Postman was followed by taking screenshots of both the request setup and the result.

---