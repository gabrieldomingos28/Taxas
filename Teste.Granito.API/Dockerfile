FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Teste.Granito.API/Teste.Granito.API.csproj", "Teste.Granito.API/"]
RUN dotnet restore "Teste.Granito.API/Teste.Granito.API.csproj"
COPY . .
WORKDIR "/src/Teste.Granito.API"
RUN dotnet build "Teste.Granito.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Teste.Granito.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Teste.Granito.API.dll"]