# DeployAppAPINaAwsLambda
<h1>Projeto 026</h1> 
<h1>Implementando CQRS com MediatR no Asp Net Core</h1> 

<p align="center">
  <img src="http://img.shields.io/static/v1?label=License&message=MIT&color=green&style=for-the-badge"/>
  <img src="http://img.shields.io/static/v1?label=NetCore&message=7.0&color=red&style=for-the-badge"/>
  <img src="http://img.shields.io/static/v1?label=TESTES&message=%3E100&color=GREEN&style=for-the-badge"/>
  <img src="http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=GREEN&style=for-the-badge"/>
</p>

## Descrição do projeto 

<p align="justify">
  Projeto para a implantação do padrão CQRS em uma Web API, utilizando o padrão Mediator.
O padrão Mediator cuida das interações entre diferentes objetos, fornecendo uma classe mediadora que coordena todas as interações entre os objetos, com o objetivo de diminuir o acoplamento e a dependência entre eles e facilitando as manutenções. Assim, usando o padrão nenhum objeto conversa diretamente com outro, sempre um objeto utilizará a classe mediadora para conversar indiretamente com outros objetos.
O CQRS - Command Query Responsibility Segregation, é um padrão de arquitetura de desenvolvimento de software que permite realizar a separação de leitura e escrita em dois modelos: Query e Command, uma para leitura e outra para escrita de dados, respectivamente.
Command refere-se a um comando de banco de dados, que pode ser uma operação Inserir/Atualizar ou Excluir;
Query significa Consultar dados de uma fonte.;
Assim, o CQRS separa as responsabilidades em termos de leitura e escrita, o que faz muito sentido. Esse padrão foi originado do Princípio Command and Query Separation desenvolvido por Bertrand Meye [MACORATTI, 2023].
</p>

## Linguagens, dependencias e libs utilizadas :books:

- Visual Studio 2022.
- Asp.Net Core 3.1.
- C#.
- MediatR.
- Postman

## Desenvolvedores/Contribuintes :octocat:

<p align="justify">
  Luiz Forçan. 
</p>

## Licença 

The [MIT License]() (MIT)

Copyright :copyright: 2023 - Implementando uma aplicação web API na Aws Lambda
