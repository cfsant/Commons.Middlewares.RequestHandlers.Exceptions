## README.md

**[Repositories]:**
[Github](https://github.com/cfsant/Commons.Middlewares.RequestHandlers.Exceptions)
[Nuget](https://www.nuget.org/packages/Commons.Middlewares.RequestHandlers.Exceptions/)


**[Description]:**
This library contains the definitions of exceptions known by the request handler.

**[Types defined]:**
> InternalException;\n
> DeveloperInternalException;\n
> ProductionInternalException;\n

**[xUnit]:**

1. DOTNET RESTORE:
```
dotnet restore .\Commons.Middlewares.RequestHandlers.Exceptions.Tests\Commons.Middlewares.RequestHandlers.Exceptions.Tests.csproj
```

2. DOTNET BUILD:
```
dotnet build --no-restore .\Commons.Middlewares.RequestHandlers.Exceptions.Tests\Commons.Middlewares.RequestHandlers.Exceptions.Tests.csproj
```

3. DOTNET TEST:
```
dotnet test
```


**[Commons.Middlewares.RequestHandlers.Exceptions]:**

1. DOTNET RESTORE:
```
dotnet restore .\Commons.Middlewares.RequestHandlers.Exceptions\Commons.Middlewares.RequestHandlers.Exceptions.csproj
```

2. DOTNET BUILD:
```
dotnet build --no-restore .\Commons.Middlewares.RequestHandlers.Exceptions\Commons.Middlewares.RequestHandlers.Exceptions.csproj
```

3. DOTNET PACK:
```
dotnet pack -o ./ .\Commons.Middlewares.RequestHandlers.Exceptions\Commons.Middlewares.RequestHandlers.Exceptions.csproj -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
```

4. NUGET PUSH:
```
nuget push ./Commons.Middlewares.RequestHandlers.Exceptions.${{env.VERSION}}.nupkg -Source 'https://api.nuget.org/v3/index.json' -ApiKey ${{secrets.MAIN}} -SkipDuplicate
```
