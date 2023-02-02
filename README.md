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
  Um projeto para implementar o padrão CQRS em uma API da Web usando o padrão Mediator.
O padrão Mediator lida com interações entre diferentes objetos fornecendo uma classe mediadora que coordena todas as interações entre objetos. Desta forma, nenhum objeto conversa diretamente com outro objeto, o objeto utilizará a classe mediadora para se comunicar indiretamente com outros objetos, diminuindo o acoplamento e dependência entre eles e facilitando a manutenção.
CQRS - Command Query Responsibility Segregation, é uma arquitetura de desenvolvimento de software que permite implementar a segregação de leitura e escrita em dois modelos: Query e Command, um para leitura e outro para escrita de dados.
Comando refere-se a um comando de banco de dados, que pode ser uma das operações: Inserir/Atualizar ou Excluir;
Query significa Consultar dados da fonte.;
Então o CQRS separa as responsabilidades em termos de leitura e escrita. Esse padrão vem da teoria de separação comando-consulta desenvolvida por Bertrand Meye. [1][2][3].
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
