# Introduction

> This repository is for the Group 2 backend code of Bright Minds Pre-school website for the DIAMOND PINNACLE IT SOLUTIONS JAN-JUN VOLUNTEER PROGRAM PROJECT NUMBER SD001A

## Tech Stack

- C#
- .Net Core
- SQLite with Microsoft Entity Framework Core

## Microsoft Entity Framework Core
> Open "Package manager console" and run `dotnet tool install --global dotnet-ef` to install the Microsoft Entity Framework Core Tool globally on your machine.

## Migrations
> On initial cloning of the application you should run a migration to update your database. 
> To run the migration open the "Package manager console" and make sure you are in the root directory of your project not solution folder.
* Run the command `dotnet ef migrations add Initial`   // Initial is the title of the migration, you can name it appropriately.
* Run `dotnet-ef database update` to write changes to the database
* After creating the migration and updating the database a folder called "Migrations" will be added in the project and a database as well.
* Whenever you there are changes to the data models in the `DataContext` class run migrations to update your database.

## Contributors

- Simba Pfaira
- Add your name here

## How to contribute

- Fork this repository by clicking the "Fork" button. This creates your own copy of the repository on your own Github account to work on.
- Visit your Github repositories page and find your version of the forked project. Clone it to your local repository to make contribute.
- You can work on the master branch or as a good practice you can create a new branch to keep your changes separate from the main branch.
- Make your code changes to implement a feature or bug fix. Test your changes thoroughly.
- After you are done commit your changes with a descriptive commit message.
- Push your changes to your forked version of the repository on GitHub.
- Go to the project on your github account and open a pull request from your branch to the upstream repository. Describe your changes and why you made them and create a pull request.
- Before creating a pull request make sure your commit does not have conflicts with the upstream repository.
- Always pull from origin everyday to keep in sync with upstream repository to minimize conflicts on creating a pull request.
