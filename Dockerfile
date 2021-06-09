FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
ENV ASPNETCORE_URLS=http://+:80  
COPY . /source

WORKDIR /source/src/Web

# BUILDA E PUBLICA CODIGO
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-restore

# SETA O DIRETORIO BASE PARA ENTRYPOINT
WORKDIR /app

# EXPOSE 8080 443
ENTRYPOINT ["dotnet", "Web.dll"]
