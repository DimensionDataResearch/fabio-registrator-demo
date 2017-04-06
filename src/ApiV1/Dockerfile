FROM microsoft/dotnet:1.1.1-runtime

EXPOSE 6920

RUN mkdir -p /app
COPY bin/Debug/netcoreapp1.1/publish /app

WORKDIR /app
ENTRYPOINT dotnet ApiV1.dll
