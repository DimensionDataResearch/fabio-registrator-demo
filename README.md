# A quick demo - Fabio with Consul and Registrator

## The containers

* [Fabio](https://github.com/eBay/fabio)  
  Acts as the front-end for APIs
* 4 API end-points (.NET Core)
  * 2 x API v1
  * 2 x API v2
* [Consul](https://consul.io)  
  Service discovery / registration
* [Registrator](https://gliderlabs.com/registrator/latest/)  
  Automatically registers API containers with Consul

## Getting started

```bash
docker-compose up
```

Then visit http://localhost:9020/api/v1 and http://localhost:9020/api/v2.

TODO: Further documentation.
