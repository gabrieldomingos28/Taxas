FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Teste.Granito.Calculo.API/Teste.Granito.Calculo.API.csproj", "Teste.Granito.Calculo.API/"]
RUN dotnet restore "Teste.Granito.Calculo.API/Teste.Granito.Calculo.API.csproj"
COPY . .
WORKDIR "/src/Teste.Granito.Calculo.API"
RUN dotnet build "Teste.Granito.Calculo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Teste.Granito.Calculo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Teste.Granito.Calculo.API.dll"]