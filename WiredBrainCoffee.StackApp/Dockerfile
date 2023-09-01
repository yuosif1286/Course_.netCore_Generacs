FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WiredBrainCoffee.StackApp/WiredBrainCoffee.StackApp.csproj", "WiredBrainCoffee.StackApp/"]
RUN dotnet restore "WiredBrainCoffee.StackApp/WiredBrainCoffee.StackApp.csproj"
COPY . .
WORKDIR "/src/WiredBrainCoffee.StackApp"
RUN dotnet build "WiredBrainCoffee.StackApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WiredBrainCoffee.StackApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WiredBrainCoffee.StackApp.dll"]
