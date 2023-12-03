# _Shelter API_

#### By _Joseph Murray_

#### _A Console App that keeps track of animels kept at a shelter_

## Description

The Shelter API is an app that keeps track of a shelter's inventory of pets. Users can keep browse what kinds of animals are at the shelter and view various details about each one.

## Technologies Used

- C#
- .NET 6.0
- Entity Framework Core
- Swagger

## Setup Instructions

- Note: An installation of the .NET SDK is required in order to run this application locally. [See Here](https://dotnet.microsoft.com/en-us/) for installation.

- Optionally, download and install Postman [here](https://www.postman.com/downloads/).

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "Shelter".
3. Create a file named `appsettings.json`: `$ touch appsettings.json`
4. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

   ```json
   {
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "AllowedHosts": "*",
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=shelter;uid=root;pwd=epicodus;"
     }
   }
   ```

5. Set up the database: `$ dotnet ef database update`
6. Navigate to the project directory: `$ cd Shelter`
7. Run `$ dotnet watch run` in the command line to start the project in development mode with a watcher.
8. Open the browser at: _https://localhost:5000/swagger/index.html_. If you cannot access localhost:5000 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

None forthcoming. Consider visiting [the repository](https://github.com/asparageist/shelter) to submit any issues.

## Licensing Info

*Copyright (c) 2023 Joseph Murray
*MIT license below
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
