#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Coladel.GerenciadorPedidos/A4S.ERP.csproj", "Coladel.GerenciadorPedidos/"]
COPY ["Coladel.GerenciadorPedidos.Infra/A4S.ERP.Infra.csproj", "Coladel.GerenciadorPedidos.Infra/"]
COPY ["Coladel.Application/A4S.ERP.Application.csproj", "Coladel.Application/"]
COPY ["Coladel.Core/A4S.Core.csproj", "Coladel.Core/"]
COPY ["Coladel.GerenciadorPedidos.Domain/A4S.ERP.Domain.csproj", "Coladel.GerenciadorPedidos.Domain/"]
RUN dotnet restore "Coladel.GerenciadorPedidos/A4S.ERP.csproj"
COPY . .
WORKDIR "/src/Coladel.GerenciadorPedidos"
RUN dotnet build "A4S.ERP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "A4S.ERP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "A4S.ERP.dll"]