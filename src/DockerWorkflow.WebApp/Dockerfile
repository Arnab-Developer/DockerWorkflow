FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY src/DockerWorkflow.WebApp/bin/publish/ ./app
WORKDIR /app
ENTRYPOINT ["dotnet", "DockerWorkflow.WebApp.dll"]