FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

ENV PORT 8080
EXPOSE 8080

ENV ASPNETCORE_URLS "http://*:${PORT}"

WORKDIR /src
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out
    
    
# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /src/out .
ENTRYPOINT [ "dotnet", "Api.dll" ]