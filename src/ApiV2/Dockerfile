FROM microsoft/dotnet:1.0-core

EXPOSE 6921

RUN mkdir -p /app
COPY bin/Debug/netcoreapp1.0/publish /app

WORKDIR /app
ENTRYPOINT dotnet ApiV2.dll
