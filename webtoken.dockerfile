FROM microsoft/dotnet:latest 

ENV ASPNETCORE_URLS="http://*:5000" 

ENV ASPNETCORE_ENVIRONMENT="Development" 

WORKDIR /app 

COPY /./WebToken /app 

RUN dotnet restore

RUN dotnet build

EXPOSE 5000/tcp

ENTRYPOINT ["dotnet", "run"]

