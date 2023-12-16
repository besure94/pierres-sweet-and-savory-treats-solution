# Pierre's Sweet and Savory Treats

#### A web application that allows a user (Pierre), to market treats and flavors for his expanding business.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* ASP.NET MVC
* MySQL

## Description

This application presents Pierre with a splash page for his dessert business. It lists all of the treats and flavors that he sell. Pierre can navigate to `Manage treats` or `Manage flavors` to begin adding treats and flavors to his business. **NOTE: In order to create, update, and delete treats and flavors, Pierre will need to register for an account first. Once he is logged in, he can freely use all of the application's functionality.** If he is logged out, he can only view the lists of treats and flavors, and see their details. For this reason, register for an account and log in before proceeding.

To create a treat, Pierre can navigate to a form where he enters a name and description for the treat. Once it is created, he can view the treat's details by clicking on it. The treat's details contain a list of all of the flavors it has. For example, a chocolate covered pretzel could have multiple flavors, such as sweet, cruncy, and salty. Pierre can add flavors to the specific treat, and can also edit the treat or delete it entirely. He can also delete individual flavors from the list in the treat's details. There must be at least one flavor in the application in order to add it to a treat.

To create a flavor, Pierre can navigate to a form where he enters a name for the flavor. Once it is created, he can view the flavor's details by clicking on it. The flavor's details contain a list of all of the treats it has. For example, a "sweet" flavor could have chocolate covered pretzels, fudge brownies, and chocolate chip cookies. Pierre can add treats to the specific flavor, and can also edit the flavor or delete it entirely. He can also delete individual treats from the list in the flavor's details. There must be at least one treat in the application in order to add it to a flavor.

## Setup Instructions

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

### Set Up and Run Project

1. From GitHub, select the green button that says `Code`, and clone this repository to your desktop.
2. Open the terminal and navigate to this project's production directory called `PierresTreats`.
3. Within the production directory `PierresTreats`, create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, always assume the `uid` is `root` and the `pwd` is `epicodus`. You can use the database name below, or name it whatever you like.

```json
{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=pierres-sweet-and-savory-treats;uid=root;pwd=epicodus;"
    }
}
```

5. Open your terminal to the production directory called `PierresTreats`, and run `dotnet ef database update`. This will create the database using the migrations located inside this project's `Migrations` folder. You should now see the database in your MySQL workbench.
    * If you need to create your own migration, run the command `dotnet ef migrations add MigrationName`. The migration name should be specific and in UpperCamelCaseFormat.
6. Within the production directory called `PierresTreats`, run `dotnet watch run` in the command line to start the project in development mode with a watcher.
7. Open the browser to [https://localhost:5001](https://localhost:5001). If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this LearnHowToProgram.com lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-2-basic-web-applications/3-2-0-17-redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

Application is fully functional.

## License

MIT

Copyright(c) 2023 Brian Scherner