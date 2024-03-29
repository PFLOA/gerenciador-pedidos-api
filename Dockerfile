# Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY ["./Coladel.GerenciadorPedidos", "./"]

RUN dotnet restore "A4S.Modulo.Email/A4S.Modulo.Email.csproj"
COPY . .

WORKDIR "/src"
RUN dotnet build "A4S.Modulo.Email/A4S.Modulo.Email.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "A4S.Modulo.Email/A4S.Modulo.Email.csproj" -c Release -o /app/publish /p:UseAppHost=false


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "A4S.Modulo.Email.dll"]

