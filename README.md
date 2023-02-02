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
O padrão Mediator trata das interações entre diferentes objetos, fornecendo uma classe mediadora que coordena todas as interações entre os objetos. Desta forma nenhum objeto conversa diretamente com outro, um objeto utilizará a classe mediadora para conversar indiretamente com outros objetos, reduzindo o acoplamento e a dependência entre eles e facilitando as manutenções. 
O CQRS - Command Query Responsibility Segregation, é um padrão de arquitetura de desenvolvimento de software que permite implementar a separação de leitura e escrita em dois modelos: Query e Command, uma para leitura e outra para escrita de dados, de modo respectivo.
Command refere-se a um comando de banco de dados, que pode ser uma das operações: Inserir/Atualizar ou Excluir;
Query significa Consultar dados de uma fonte.;
Assim, o CQRS separa as responsabilidades em termos de leitura e escrita, o que faz muito sentido. Esse padrão foi originado da Teoria Command and Query Separation desenvolvida por Bertrand Meye [1][2][3].
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

## Referências :books:

- [1] MACORATTI, J. C., https://www.macoratti.net/20/10/aspc_cqrsmedr1.htm.
- [2] NAYAN, B. D. https://www.c-sharpcorner.com/article/implementing-cqrs-with-mediatr-in-asp-net-core-application/
- [3] PATIL, J., https://www.c-sharpcorner.com/article/cqrs-and-mediatr-pattern-implementation-using-net-core-6-web-api/
## Licença 

The [MIT License]() (MIT)

Copyright :copyright: 2023 - Implementando uma aplicação web API na Aws Lambda
