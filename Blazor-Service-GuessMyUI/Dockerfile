FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base

COPY exporting.conf /etc/netdata/exporting.conf

RUN apt-get update && apt-get install -y wget && rm -rf /var/lib/apt/lists/*

RUN wget -O /tmp/netdata-kickstart.sh https://my-netdata.io/kickstart.sh 
RUN sh /tmp/netdata-kickstart.sh --non-interactive --disable-cloud --dont-start-it

ENV NATIONSERVICEIP=localhost
ENV NATIONSERVICEPORT=3001

WORKDIR /app

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

COPY docker_startup.sh .
RUN chmod +x /app/docker_startup.sh
ENTRYPOINT ["/app/docker_startup.sh" ]