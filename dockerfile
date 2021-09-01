FROM mcr.microsoft.com/dotnet/sdk:5.0
COPY ./knightsapi/bin/Release/net5.0/publish/ App/
WORKDIR /App
CMD ASPNETCORE_URLS=http://*:$PORT dotnet knightsapi.dll
