FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DesignPatters.Studies/DesignPatters.Studies.csproj", "DesignPatters.Studies/"]
RUN dotnet restore "DesignPatters.Studies/DesignPatters.Studies.csproj"
COPY . .
WORKDIR "/src/DesignPatters.Studies"
RUN dotnet build "DesignPatters.Studies.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesignPatters.Studies.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPatters.Studies.dll"]
