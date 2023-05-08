# TutApp API
The TutApp API is a RESTful API that provides users with access to a variety of tutorials on different topics. The API allows users to search for tutorials by keyword, category, and author, as well as view and download tutorials in various formats.

## Table of Contents

[Installation](#installation) <br>
[usage](#usage) <br>
[Features](#features) <br>
[Code Features](#code-features) <br>
[Troubleshooting](#troubleshooting)

### Installation

To install the TutApp API, follow these steps:

- Clone the repository to your local machine using the following command:

```bash
git clone https://github.com/yehonatan604/TutApp.git
```
- Open the solution file TutApp.sln in Visual Studio.

- Build the solution to restore NuGet packages and compile the project.

- Create a new Microsoft SQL Server database to store the application data.

- Open the file appsettings.json located in the TutApp project folder and modify the following connection string with your own Microsoft SQL Server database connection string:

```bash
"ConnectionStrings": {
  "TutAppDbConnection": "Server=<your-server-name>;Database=<your-database-name>;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

- Open the Package Manager Console in Visual Studio, select the TutApp.Data project, and run the following command to create the database schema:

```bash
Update-Database
```

- Run the project in Visual Studio, The API server should now be running on your local machine & you should see Swagger Api Documentation.

### Usage
The TutApp API provides the following endpoints:

- GET v1/api/articles - Retrieves a list of tutorials based on the specified search criteria.

- GET v1/api/articles/{id} - Retrieves a tutorial with the specified ID.

- POST v1/api/articles - Creates a new tutorial (Creator authorization level only).

- PUT v1/api/articles/{id} - Updates an existing tutorial with the specified ID (Creator authorization level only).

- DELETE v1/api/articles/{id} - Deletes a tutorial with the specified ID (Creator/Admin authorization level only).

- To use the API, you can send HTTP requests to these endpoints using a tool such as Postman or cURL or Swagger or use TutApp frontend app.

- Authorization implemented in swagger

### Features

- User Registration: - In this module user must register himself by filling some personal details.

- User Login: After registration user will enter Email and password for logging in order to get access to the system.

- Search in Articles: User can search/sort articles.

- Create articles: Creators can create new articles.

- Massages: User can get & send messages to the admin.

- Personal: User can edit personal details, Creator can edit/delete his articles aswell.

### Code Features:

- The program is divided into 3 projects implementing the N-Tiers Architecture.
- Database is created with Entity Framework Code First.
- Data is seeded on installation.
- queries are written in LINQ.
- The Db connector the generic repository is Singleton.
- Usage of Repository Pattern & implementation of dependency injection.
- Usage of AutoMapper & DTO's.
- Usage of OData queries for filtering/ordering/sorting.
- Global Exception Handling custom Middleware for Auth Controller with custom exceptions.
- JWT Authentication.
- Authorization: 3 different user roles - ["User", "Creator", "Admin"].
- Identity Core usage.  
- Caching: responses are saved in cache for 10 seconds.
- Api Versioning for possiable future development.
- Passwords are hashed.

### Troubleshooting
If you encounter any issues when using the TutApp API, please refer to the project's GitHub Issues page to see if a solution has already been proposed. If not, you can open a new issue to report the problem.
