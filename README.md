# ProEventos

O projeto "ProEventos" é um aplicativo de CRUD em camadas desenvolvido em C#, que utiliza o Entity Framework Core como ORM para interagir com um banco de dados SQL Server. O objetivo do aplicativo é gerenciar eventos, permitindo a criação, leitura, atualização e exclusão de registros relacionados a eventos. Foi Também desenvolvida utilizando o conceito de injeção de dependência, o que contribui para a modularidade e flexibilidade do código.

A aplicação "ProEventos" começou com a versão 6 do .NET, mas foi atualizada para a versão 7 do .NET. Durante o desenvolvimento, a pasta "Startup" foi utilizada para explorar conceitos de aplicações mais antigas.

O projeto é estruturado em camadas, o que facilita a manutenção e a separação de responsabilidades. As principais camadas são: 

### Camada Persistence (Persistência):

Essa camada é responsável pela interação com o banco de dados e o gerenciamento das operações de persistência.
Ela contém classes que implementam o acesso aos dados utilizando o Entity Framework Core.
Nessa camada, você encontrará as classes de contexto que representam as tabelas do banco de dados e as configurações de mapeamento das entidades.


### Camada Domain (Domínio):

Essa camada contém as classes e modelos de domínio do  projeto.
Ela representa as entidades e regras de negócio do seu sistema.


### Camada Application (Aplicação):

Essa camada é responsável pela lógica de aplicação e pelos serviços oferecidos pelo seu projeto.
Ela contém as classes que implementam a lógica de negócio e as operações do CRUD.
Aqui, você pode ter classes como EventoPersist, PalestrantePersist, etc., que realizam as operações de manipulação dos dados e implementam as regras de negócio.


### Camada API:

Essa camada é responsável pela exposição dos serviços e pela interação com os clientes externos.
Ela utiliza um framework para construir uma API RESTful, como o ASP.NET Core Web API.
Nessa camada, estão os endpoints, controladores, roteamento e a lógica para receber e responder às requisições HTTP.


Além disso, o projeto faz uso de operações assíncronas, o que permite um melhor aproveitamento dos recursos do sistema e uma melhor escalabilidade. Essas operações assíncronas são implementadas utilizando a palavra-chave async e os métodos Task<T>.

Com essa estrutura e tecnologias utilizadas, o projeto "ProEventos" é capaz de criar, ler, atualizar e excluir eventos, além de gerenciar relacionamentos entre entidades, como palestrantes, participantes e locais. Ele oferece uma maneira eficiente e organizada de lidar com a persistência e manipulação de dados, seguindo boas práticas de desenvolvimento.


## Modelagem do banco de dados
  
![ProEventos drawio](https://github.com/Cristian-ferre/ProEventos/assets/99483009/ccbed2fc-3d1f-4e21-9bb3-82013d216d19)



## Contribuição

Este é um projeto de código aberto e contribuições são sempre bem-vindas. Se você deseja contribuir, siga os seguintes passos:

- Faça um fork deste repositório
- Crie uma nova branch com suas alterações (git checkout -b minha-nova-feature)
- Commit suas alterações (git commit -am 'Adicionando nova feature')
- Push para a branch (git push origin minha-nova-feature)
- Crie um novo Pull Request
