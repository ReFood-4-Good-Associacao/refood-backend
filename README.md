# Introduction
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:

1.	Installation process
- clone git repository: https://afilipem.visualstudio.com/Refood/_git/Refood ;
- open the Refood solution in Visual Studio;
- in Visual Studio open the menu Tools > NuGet package manager > restore packages;
- build solution in Visual Studio;
- open SQL Server Management Studio; 
- create a new database "Refood";
- open and run the create tables sql script: "Refood\Refood.Core\Database\create tables.sql"; 
- open and run the sql insert scripts: "Refood\Refood.Core\Database\insert scripts.sql"; 
- open the web.config file located in Refood.Web project folder, and edit the connection string, pointing to the Refood database.
- open IIS (Internet Information Services) and add a web app, then select the Refood.Web project folder;
- in IIS, click the local website link to open it. ex: http://localhost/Refood.Web

2.	Software dependencies
- Visual Studio 2015 (or superior)
- SQL Server 2014 (or superior)
- IIS - Internet Information Services (Windows)
     
3.	Latest releases
- DEV - http://refoodweb.azurewebsites.net/
- QA - TODO (Azure)
- PROD - TODO (Azure)

4.	API references
- asp.net
- PetaPoco ORM
- T4 Templates
- knockoutjs
- jquery
- jquery-ui
- jquery.datatables
- bootstrap
- toastr.js
- Newtonsoft.Json
- log4net
- MSTest
- Swashbuckle
- Swagger
- Owin
- Web ApiController

# Build and Test
How to build your code and run the tests.
- TODO: develop unit tests. 

# Publish
How to publish the app.
- Tutorial - [Publish to Azure](https://docs.microsoft.com/en-us/azure/app-service/app-service-web-get-started-dotnet#publish-to-azure) (manual)
- Continuous Integration - (work in progress - there's an issue with automatic deploy authentication to azure vm, insuficient AD permissions)

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://www.visualstudio.com/en-us/docs/git/create-a-readme). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
