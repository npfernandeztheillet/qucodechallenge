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
#### Docker 
#### Visual Studio (Code or community)
#### .Net Core runtime

## Built with 🛠️
* Visual studio 2019
* Docker
* MediatR
* FluentAssertions
* xUnit
* Swagger

## Run application locally 🚀
User can run the application on different ways, using docker compose or using iisexpress.
For docker compose, stay inside QU folder (qucodechallenge\Qu), run next command in a terminal:
``` bash
docker-compose up --build
```
## Run tests locally 🚀
``` bash
dotnet test test/Qu.Unit.Test/Qu.Unit.Test.csproj --no-build -c Release
```

