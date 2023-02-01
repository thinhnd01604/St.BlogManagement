# St.BlogManagement

## Requirements

* [.NET 7.0+](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
* [Redis - for window](https://redis.io/docs/getting-started/installation/install-redis-on-windows/)

## Setup Development environment

* [SQL Server](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
* [IDE - Visual Studio](https://visualstudio.microsoft.com/downloads/)
* [ABP CLI](https://docs.abp.io/en/abp/latest/Getting-Started-Setup-Environment?UI=Blazor&DB=EF&Tiered=No)

## Document References

* [ABP CLI - New solution sample commands](https://github.com/abpframework/abp/blob/dev/docs/en/CLI-New-Command-Samples.md)
* [ABP Web Application Tutorials](https://docs.abp.io/en/commercial/latest/tutorials/book-store/part-1?UI=Blazor&DB=EF)
* [ABP - EventHub: Sample project](https://github.com/abpframework/eventhub)

## How to run

* Execute dotnet build /graphBuild command in the root folder of the solution.
* Run St.BlogManagement.DbMigrator to create the database and seed initial data.
* Run St.BlogManagement.AuthServer
* Run St.BlogManagement.HttpApi.Host
* Run St.BlogManagement.Web
* Run St.BlogManagement.Admin.HttpApi.Host
* Run St.BlogManagement.Admin.Web

## Screenshots

### Source code structure

![Source code](etc/captures/Source code structure.png)

### Default sample app
#### (TODO: Remove after finish new features)
#### (TODO: Capture new screens)

![Authen server](etc/captures/Default sample - AuthenServer.png)
![Swagger (Api app)](etc/captures/Default sample - Swaggers.png)
![Home Page](etc/captures/Default sample - Homepage.png)

