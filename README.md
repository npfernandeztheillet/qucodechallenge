# qu-code challenge 

## Starting 🚀
The main objective of qu-code challenge application is to

To achieve that, we have different projects whose objectives are quite different:

#### Qu.API:
Web application with one API rest endpoint
The main objective of this app is to receive request from different clients that want to find words and return the top 10 words.

#### Qu.Words:
Shared project library that contains domain model (DDD), handlers and wordfinder class (as service).

#### Qu.Words.Contracts:
Shared project library that contains different contract, request and responses.

#### Qu.Unit.Test:
Unit test project.

### Pre-requisites 📋
#### Visual Studio (Code or community)
#### .Net Core runtime

## Built with 🛠️
* Visual studio 2019
* MediatR
* FluentAssertions
* xUnit
* Swagger

## Run application locally 🚀
On root folder, run next command in a terminal:
``` bash
dotnet run --project ./Qu/Qu.API.csproj
```
After that enter to  http://localhost:5000/swagger

## Run tests locally 🚀
On root folder, run next command in a terminal:
``` bash
dotnet test Qu.Unit.Test/Qu.Unit.Test.csproj -c Release
```

