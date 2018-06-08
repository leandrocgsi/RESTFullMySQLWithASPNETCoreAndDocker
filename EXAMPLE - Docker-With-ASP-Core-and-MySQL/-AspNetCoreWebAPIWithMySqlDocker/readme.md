
# ASP.NET Core Web API with MySql running in Docker

Sample app to demonstrate the deployment of a simple ASP.NET core Web API with a MySql database in docker containers.

## Pre-requisite

Microsoft Core SDK https://go.microsoft.com/fwlink/?LinkID=835014

Docker https://www.docker.com/

## Getting started

Clone this repository ```git clone https://github.com/abariatti/AspNetCoreWebAPIWithMySqlDocker.git```

```cd AspNetCoreWebAPIWithMySqlDocker```

```docker-compose up -d```

Go to http://localhost:5000/api/sessions

## Managing Docker

Show running containers

```docker ps```

```
CONTAINER ID        IMAGE                  COMMAND                  CREATED             STATUS              PORTS                    NAMES
7c72c49ac0db        conferenceapp-webapi   "dotnet run"             4 minutes ago       Up 4 minutes        0.0.0.0:5000->5000/tcp   aspnetcorewebapiwithmysqldocker_aspnetcoreserver_1
b53182ab27a5        conferenceapp-mysql    "docker-entrypoint..."   4 minutes ago       Up 4 minutes        0.0.0.0:3306->3306/tcp   aspnetcorewebapiwithmysqldocker_mysqlserver_1
```

Stopping containers

``` docker stop 7c72c49ac0db b53182ab27a5 ```

Deleting containers

``` docker rm 7c72c49ac0db b53182ab27a5 ```

Deleting volumes

``` docker volumes prune ```

Deleting images 

``` docker images ```
```
REPOSITORY             TAG                 IMAGE ID            CREATED             SIZE
conferenceapp-webapi   latest              be0ce7c7af59        7 minutes ago       901 MB
conferenceapp-mysql    latest              07345c95e5a6        8 minutes ago       406 MB
``` 

``` docker rmi be0ce7c7af59 07345c95e5a6 ```

## During development 

Stop both containers

``` docker ps -a ```
```
CONTAINER ID        IMAGE                  COMMAND                  CREATED             STATUS                      PORTS               NAMES
7c72c49ac0db        conferenceapp-webapi   "dotnet run"             33 minutes ago      Exited (0) 38 seconds ago                       aspnetcorewebapiwithmysqldocker_aspnetcoreserver_1
b53182ab27a5        conferenceapp-mysql    "docker-entrypoint..."   33 minutes ago      Exited (0) 35 seconds ago                       aspnetcorewebapiwithmysqldocker_mysqlserver_1
```

Start only MySql container

docker start b53182ab27a5