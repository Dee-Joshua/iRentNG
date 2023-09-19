#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["IRentNg.WebApi/IRentNG.API.csproj", "IRentNg.WebApi/"]
COPY ["IRentNG.LoggerService/IRentNG.LoggerService.csproj", "IRentNG.LoggerService/"]
COPY ["IRentNG.Contracts/IRentNG.Contracts.csproj", "IRentNG.Contracts/"]
COPY ["IRentNG.Entities/IRentNG.Entities.csproj", "IRentNG.Entities/"]
COPY ["IRentNG.Shared/IRentNG.Shared.csproj", "IRentNG.Shared/"]
COPY ["IRentNG.Presentation/IRentNG.Presentation.csproj", "IRentNG.Presentation/"]
COPY ["IRentNG.Service.Contracts/IRentNG.Service.Contracts.csproj", "IRentNG.Service.Contracts/"]
COPY ["IRentNG.Repository/IRentNG.Repository.csproj", "IRentNG.Repository/"]
COPY ["IRentNG.Service/IRentNG.Service.csproj", "IRentNG.Service/"]
RUN dotnet restore "IRentNg.WebApi/IRentNG.API.csproj"
COPY . .
WORKDIR "/src/IRentNg.WebApi"
RUN dotnet build "IRentNG.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IRentNG.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IRentNG.API.dll"]