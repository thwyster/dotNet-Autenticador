FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["dotNet-Autenticador.Client/dotNet-Autenticador.Client.csproj", "dotNet-Autenticador.Client/"]
RUN dotnet restore "dotNet-Autenticador.Client/dotNet-Autenticador.Client.csproj"
COPY . .
WORKDIR "/src/dotNet-Autenticador.Client"
RUN dotnet build "dotNet-Autenticador.Client.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dotNet-Autenticador.Client.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dotNet-Autenticador.Client.dll"]