## Commons.Middlewares.RequestHandlers.Exceptions

**[Repositories]:** <br/>
— [Github](https://github.com/cfsant/Commons.Middlewares.RequestHandlers.Exceptions) <br/>
— [Nuget](https://www.nuget.org/packages/Commons.Middlewares.RequestHandlers.Exceptions/) <br/>


**[Description]:** <br/>
This library contains the definitions of exceptions known by the request handler. <br/>


**[SonarScanner]:** <br/>
Code review through SonarCloud API integrated with SonarScanner via Github Actions. <br/>


**[Types defined]:** <br/>
— InternalException &nbsp;&nbsp; [&nbsp;*json { Message: "" }*&nbsp;];<br/>
— DeveloperInternalException &nbsp;&nbsp; [&nbsp;*json { Message: "", InnerException: {}, StackTrace: "" }*&nbsp;];<br/>
— ProductionInternalException &nbsp; [ *json { Message: "", Detail: "" }* ];<br/>


**[Commons.Middlewares.RequestHandlers.Exceptions]:** <br/>
To compile the code library, run the commands below: <br/>

```
dotnet restore .\Commons.Middlewares.RequestHandlers.Exceptions\Commons.Middlewares.RequestHandlers.Exceptions.csproj
dotnet build --no-restore .\Commons.Middlewares.RequestHandlers.Exceptions\Commons.Middlewares.RequestHandlers.Exceptions.csproj -p:Version=${{env.VERSION}}
```

**[Commons.Middlewares.RequestHandlers.Exceptions.Tests (xUnit)]:**<br/>
To run the library xUnit tests, run the commands below: <br/>

```
dotnet restore .\Commons.Middlewares.RequestHandlers.Exceptions.Tests\Commons.Middlewares.RequestHandlers.Exceptions.Tests.csproj <br/>
dotnet build --no-restore .\Commons.Middlewares.RequestHandlers.Exceptions.Tests\Commons.Middlewares.RequestHandlers.Exceptions.Tests.csproj <br/>
dotnet test
```

**[Pack & Push (.nupkg):]** <br/>
To package the code library and publish the .nupkg package, run the commands below: <br/>

```
dotnet pack -o ./ .\Commons.Middlewares.RequestHandlers.Exceptions\Commons.Middlewares.RequestHandlers.Exceptions.csproj -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg -p:PackageVersion=${{env.VERSION}}
nuget push ./Commons.Middlewares.RequestHandlers.Exceptions.${{env.VERSION}}.nupkg -Source 'https://api.nuget.org/v3/index.json' -ApiKey ${{secrets.MAIN}} -SkipDuplicate
```
