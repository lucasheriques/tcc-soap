FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY ["soap.csproj", "./"]
RUN dotnet restore "./soap.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "soap.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "soap.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "soap.dll"]
