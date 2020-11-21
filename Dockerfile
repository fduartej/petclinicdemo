FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

#nombre de tu app busca en bin\Release\netcore3.1\myapp.exe
ENV APP_NET_CORE petclinicdemo.dll

CMD ASPNETCORE_URLS=http://*:$PORT dotnet $APP_NET_CORE