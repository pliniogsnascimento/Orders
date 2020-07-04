# Orders
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
docker run 
```

## Exemplo de uso

Alguns exemplos interessantes e úteis sobre como seu projeto pode ser utilizado. Adicione blocos de códigos e, se necessário, screenshots.

_Para mais exemplos, consulte a [Wiki][wiki]._ 

## Configuração para Desenvolvimento

Para desenvolver para p microserviço Orders, é necessário ter o sdk .net core 3.1 instalado.

```sh
dotnet run -p Orders.Api.csproj
```

## CHANGELOG

* 0.0.1
    * Trabalho em andamento

