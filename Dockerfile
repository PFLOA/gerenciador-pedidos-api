# Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 5003

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Coladel.GerenciadorPedidos/A4S.Modulo.Email/A4S.Modulo.Email.csproj", "A4S.Modulo.Email/"]

RUN dotnet restore "Coladel.GerenciadorPedidos/A4S.Modulo.Email/A4S.Modulo.Email.csproj"
COPY . .

WORKDIR "/src/A4S"
RUN dotnet build "A4S.Modulo.Email.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "A4S.Modulo.Email.csproj" -c Release -o /app/publish /p:UseAppHost=false


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "A4S.Modulo.Email.dll"]

