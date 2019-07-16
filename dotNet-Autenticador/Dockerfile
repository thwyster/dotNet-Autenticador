FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["dotNet-Autenticador/dotNet-Autenticador.csproj", "dotNet-Autenticador/"]
RUN dotnet restore "dotNet-Autenticador/dotNet-Autenticador.csproj"
COPY . .
WORKDIR "/src/dotNet-Autenticador"
RUN dotnet build "dotNet-Autenticador.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dotNet-Autenticador.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dotNet-Autenticador.dll"]