FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY RESTFullMySQLWithASPNETCoreAndDocker/RESTFullMySQLWithASPNETCoreAndDocker.csproj RESTFullMySQLWithASPNETCoreAndDocker/
RUN dotnet restore RESTFullMySQLWithASPNETCoreAndDocker/RESTFullMySQLWithASPNETCoreAndDocker.csproj
COPY . .
WORKDIR /src/RESTFullMySQLWithASPNETCoreAndDocker
RUN dotnet build RESTFullMySQLWithASPNETCoreAndDocker.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish RESTFullMySQLWithASPNETCoreAndDocker.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RESTFullMySQLWithASPNETCoreAndDocker.dll"]
