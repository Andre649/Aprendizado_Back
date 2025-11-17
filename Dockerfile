# 1. Imagem de Construção (O "Cozinheiro")
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia tudo do nosso projeto para dentro do container
COPY . .

# Restaura as dependências e compila o projeto API
RUN dotnet restore
RUN dotnet publish MisterChurras.API/MisterChurras.API.csproj -c Release -o out

# 2. Imagem de Execução (O "Garçom")
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# O Render define a porta automaticamente na variável PORT.
# Este comando diz ao .NET para usar essa porta.
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MisterChurras.API.dll