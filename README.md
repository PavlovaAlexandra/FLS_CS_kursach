## Project Overview
FLS_CS_kursach is a C# project built using ASP.NET Core. It includes a web-based application with a structured MVC architecture. This repository contains all necessary files to run and modify the project.

## Features
- **ASP.NET Core MVC** architecture
- **Configuration with appsettings.json**
- **Main controller implementation**
- **Startup configuration**

## Prerequisites
Before running this project, make sure you have the following installed:
- [Microsoft .NET SDK 6.0 or later](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/)
- SQL Server (if applicable)

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/PavlovaAlexandra/FLS_CS_kursach.git
   ```
2. Navigate to the project folder:
   ```sh
   cd FLS_CS_kursach/kursach
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```

## Configuration
Modify `appsettings.json` to match your database settings and other configurations.

## Running the Application
To run the application locally, execute the following command:
```sh
   dotnet run
```
Or, run the project from Visual Studio by pressing `F5`.

## Project Structure
```
FLS_CS_kursach/
│-- kursach.sln                    # Solution file
│-- kursach/
│   ├── Program.cs                 # Main entry point
│   ├── Startup.cs                 # Configuration and services
│   ├── appsettings.json           # Configuration settings
│   ├── Controllers/
│   │   ├── MainController.cs      # Main controller logic
│   ├── Properties/
│   │   ├── launchSettings.json    # Debugging configuration
│   ├── kursach.csproj             # Project file
```
