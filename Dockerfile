#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Presentation/Orders.Api/Orders.Api.csproj", "Orders.Api/"]
COPY ["src/Core/Orders.Domain/Orders.Domain.csproj", "Orders.Domain/"]
COPY ["src/Infrastructure/Orders.Infrastructure/Orders.Infrastructure.csproj", "Orders.Infrastructure/"]
COPY ["src/Tests/Orders.Test/Orders.Test.csproj", "Orders.Test/"]
RUN dotnet restore "Orders.Api/Orders.Api.csproj"
COPY "src/Presentation/" .
COPY "src/Infrastructure/" .
COPY "src/Core/" .
COPY "src/Tests/" .
WORKDIR "/src/Orders.Api"
RUN dotnet build "Orders.Api.csproj" -c Release -o /app/build

FROM build AS test
WORKDIR "/src/Orders.Test"
RUN dotnet test 

FROM build AS publish
RUN dotnet publish "Orders.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Orders.Api.dll"]