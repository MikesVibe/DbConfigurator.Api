#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DbConfigurator.Api/DbConfigurator.Api.csproj", "DbConfigurator.Api/"]
COPY ["DbConfigurator.Application/DbConfigurator.Application.csproj", "DbConfigurator.Application/"]
COPY ["DbConfigurator.Domain/DbConfigurator.Domain.csproj", "DbConfigurator.Domain/"]
COPY ["DbConfigurator.Infrastracture/DbConfigurator.Infrastracture.csproj", "DbConfigurator.Infrastracture/"]
COPY ["DbConfigurator.Persistence/DbConfigurator.Persistence.csproj", "DbConfigurator.Persistence/"]
RUN dotnet restore "DbConfigurator.Api/DbConfigurator.Api.csproj"
COPY . .
WORKDIR "/src/DbConfigurator.Api"
RUN dotnet build "DbConfigurator.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DbConfigurator.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DbConfigurator.Api.dll"]