FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /source

ARG BUILD_CONFIGURATION_ARG

COPY ["src/API/TheChillSpot.Todo.AccountManagement.API.csproj", "API/"]
COPY ["src/Application/TheChillSpot.Todo.AccountManagement.Application.csproj", "Application/"]
COPY ["src/Domain/TheChillSpot.Todo.AccountManagement.Domain.csproj", "Domain/"]
COPY ["src/Infrastructure/TheChillSpot.Todo.AccountManagement.Infrastructure.csproj", "Infrastructure/"]

COPY [".", "."]

RUN dotnet publish -c ${BUILD_CONFIGURATION_ARG} -o /build src/API/TheChillSpot.Todo.AccountManagement.API.csproj

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app

ARG ASPNETCORE_ENVIRONMENT_ARG

ENV ASPNETCORE_ENVIRONMENT=${ASPNETCORE_ENVIRONMENT_ARG}
ENV ASPNETCORE_URLS=http://+:80

EXPOSE 80/tcp

COPY --from=build /build .

ENTRYPOINT [ "dotnet", "TheChillSpot.Todo.AccountManagement.API.dll" ]