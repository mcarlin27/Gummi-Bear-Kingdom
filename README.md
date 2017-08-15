# Gummi Bear Kingdom

#### A program that allows users to track products in an online store, as well as each product's Country of Origin. 8/6/17

#### By **Marilyn Carlin**

## Description

A website created with C#, .Net Core, and HTML where a user can add/read/update/delete products and countries of origin in an online store. Styling is modeled after the [Haribo](https://www.haribo.com/enUS/home.html) styling.

### Specs

| Behavior | Example Input | Example Output |
| :-------------     | :------------- | :------------- |
| **All data is persisted in SQL** | User submits data | Data is saved to SQL db |
| **User can submit Products the site sells** | "Chair" | List of products |
| **User can submit Countries of Origin for products** | "Italy" | List of countries |
| **Countries of Origin have full CRUD functionality** | "Create New Country: Italy" | "Italy" added to List of countries |
| **Products have full CRUD functionality** | "Create New Product: Chair" | "Chair" added to List of Products |

## Setup/Installation Requirements
1. To run this project you must have [Visual Studio 2015](https://www.visualstudio.com/downloads/) and [SQL SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) installed on your machine.
2. Clone this repository.
3. Navigate into the GummiBearKingdom directory in Powershell and run the command "dotnet ef migrations add Initial".
7. Then run "dotnet ef database update".
9. Open the project in Visual Studio and click the green arrow button, marked "IIS Express" to run the program.

## Known Bugs
None at this time

## Technologies Used
* .NET Core
* C#

## Legal
Copyright (c) 2017 **_Marilyn Carlin_** All Rights Reserved.
Licensed under the MIT license.
