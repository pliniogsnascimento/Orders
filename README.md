# Orders API
> Microserviço responsável pelos pedidos feitos no ecommerce.

[![Version](https://badge.fury.io/gh/tterb%2FHyde.svg)](https://badge.fury.io/gh/tterb%2FHyde)

Essa aplicação é responsável por criar e gerenciar pedidos feitos pelo ecommerce. O pedido precisa ser um pedido válido no microserviço de produtos.

## Instalação

Para rodar o projeto, é necessário ter o .net core 3.1 instalado.

OS X, Linux & Windows:

```sh
dotnet restore
dotnet build "Orders.Api.csproj" -c Release -o /app/build
dotnet publish "Orders.Api.csproj" -c Release -o /app/publish
```

Docker:

```sh
docker build -t ordersapi .
docker run -p 5000:5000 ordersapi
```

## Exemplo de uso

Após rodar o projeto, acesse http://localhost:5000/swagger para obter mais informações sobre a API.

## Configuração para Desenvolvimento

Para desenvolver para p microserviço Orders, é necessário ter o sdk .net core 3.1 instalado.

```sh
dotnet run -p Orders.Api.csproj
```

## CHANGELOG

* 0.0.1
    * Trabalho em andamento

