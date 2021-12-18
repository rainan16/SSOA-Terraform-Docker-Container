FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base

ENV NATIONSERVICEIP=localhost
ENV NATIONSERVICEPORT=3001

WORKDIR /app
EXPOSE 443
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY Blazor-Service-GuessMyUI.csproj .
RUN dotnet restore "Blazor-Service-GuessMyUI.csproj"
COPY . .
RUN dotnet build "Blazor-Service-GuessMyUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blazor-Service-GuessMyUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blazor-Service-GuessMyUI.dll"]