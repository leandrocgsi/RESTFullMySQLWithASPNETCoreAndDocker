FROM microsoft/dotnet:latest

RUN apt-get update && apt-get -y install apt-utils sqlite3 libsqlite3-dev

COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

EXPOSE 5000/tcp

ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]
