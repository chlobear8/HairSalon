# Eau Claire's Salon
#### By Chloe ONeil
#### Claire's salon management

## Technologies Used
- MARKDOWN
- C#
- .NET
- Razor
- MySql

## Description
This project is built to allow Claire to add Stylists and their clients names. It can be found at <https://github.com/chlobear8/HairSalon>. Contact me with any questions, comments or concerns at <chloesporri@yahoo.com>.

## Setup/Installation Requirements
- Clone this repository to your desktop.
- Build the project using $ dotnet build.
- Download both of these packages from your terminal:
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
- Create an appsettings.json file.
- In said file include:
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
- To import from MySql:
- From Navigation>Administration window, select 'Data Import/Restore'.
- In 'Import Options' select 'Import from Self-Contained File'. (chloe_oneil.sql)
- Under 'Default Schema to be Imported To' select the 'New' button.
- Navigate to the tab called 'Import Progress' and click 'Start Import'.
- This should create a database on MySql with tables named clients and stylists.
- clients table should include columns ["ClientId", "Name" and "StylistId"].
- stylists table should include columns ["StylistId" and "Name"].
- Start a development server with $ dotnet run.


## Known bugs

No known bugs.

## License information
Copyright 2023 Chloe ONeil
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


