#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PlanningPokerBack/PlanningPokerBack.csproj", "PlanningPokerBack/"]
COPY ["UseCases/UseCases.csproj", "UseCases/"]
COPY ["Infrastructure.Interfaces/Infrastructure.Interfaces.csproj", "Infrastructure.Interfaces/"]
COPY ["Entities/Entities.csproj", "Entities/"]
COPY ["Storage.Interfaces/Storage.Interfaces.csproj", "Storage.Interfaces/"]
COPY ["Storage.Implementations/Storage.Implementations.csproj", "Storage.Implementations/"]
COPY ["Infrastructure.Implementations/Infrastructure.Implementations.csproj", "Infrastructure.Implementations/"]
COPY ["Infrastructure.Interfaces/Infrastructure.Interfaces.csproj", "Infrastructure.Interfaces/"]
RUN dotnet restore "PlanningPokerBack/PlanningPokerBack.csproj"
COPY . .
WORKDIR "/src/PlanningPokerBack"
RUN dotnet build "PlanningPokerBack.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlanningPokerBack.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlanningPokerBack.dll"]