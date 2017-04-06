# A quick demo - Fabio with Consul and Registrator

## The containers

* [Fabio](https://github.com/eBay/fabio)  
  Acts as the front-end for APIs
* 2 API end-points (.NET Core)
  * 1 x API v1
  * 1 x API v2
* [Consul](https://consul.io)  
  Service discovery / registration
* [Registrator](https://gliderlabs.com/registrator/latest/)  
  Automatically registers API containers with Consul

## Getting started

To build:

```
dotnet restore
dotnet publish src/ApiV1 -f netcoreapp1.1
dotnet publish src/ApiV2 -f netcoreapp1.1
docker-compose build
```

To run:
```
docker-compose up
```

Then visit http://localhost:5001 for UI or http://localhost:5000/api/v1 / http://localhost:5000/api/v2 for the proxied APIs.
