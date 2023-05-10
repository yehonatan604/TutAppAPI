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

- To run without installation, the site is hosted on azure: https://tutappapi-yehonatan.azurewebsites.net/v1/api/articles, add version (v1) at the start of each route.
- To use the API, you can send HTTP requests to the API's endpoints using a tool such as Postman or swagger.
- Api Documentation in Swagger: https://tutappapi-yehonatan.azurewebsites.net/swagger/index.html
- Authorization implemented in swagger, register, login & then copy the token from the response:

<a href="https://ibb.co/yVnPBGc"><img src="https://i.ibb.co/Fnb3qNL/response.png" alt="response" border="0"></a>

- click authorize & paste the token:

<a href="https://ibb.co/TmWrh8M"><img src="https://i.ibb.co/5BK2c8h/auth.png" alt="auth" border="0"></a>

- now you are authorized to access routes that was protected (according to your role's authorization level)

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
- Usage of Repository Pattern & implementation of dependency injection.
- Usage of AutoMapper & DTO's.
- Usage of OData queries for filtering/ordering/sorting.
- Global Exception Handling custom Middleware for Auth Controller with custom exceptions.
- JWT Authentication.
- Authorization: 3 different user roles - ["User", "Creator", "Admin"].
- Identity Core usage.  
- Caching: responses are saved in cache for 10 seconds.
- Api Versioning for possiable future development.

### Troubleshooting
If you encounter any issues when using the TutApp API, please refer to the project's GitHub Issues page to see if a solution has already been proposed. If not, you can open a new issue to report the problem.
