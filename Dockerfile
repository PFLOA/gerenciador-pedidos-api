# Dockerfile
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /app

COPY ./Coladel.GerenciadorPedidos/ ./

RUN dotnet restore ./Coladel.GerenciadorPedidos/Coladel.GerenciadorPedidos.csproj
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Coladel.GerenciadorPedidos.dll"]
