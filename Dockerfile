#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
EXPOSE 80
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
COPY ["OllaInvoice/OllaInvoice.csproj", "OllaInvoice/"]
COPY ["Data/Data.csproj", "Data/"]
COPY ["Entities/Entities.csproj", "Entities/"]
RUN dotnet restore "OllaInvoice/OllaInvoice.csproj"
COPY . .
WORKDIR /src/OllaInvoice
RUN dotnet build

FROM build AS publish
RUN dotnet publish "OllaInvoice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OllaInvoice.dll"]

CMD ASPNETCORE_URLS=http://*:$PORT dotnet OllaInvoice.dll