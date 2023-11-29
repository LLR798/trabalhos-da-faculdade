# API de Reserva de Hotéis.

Este repositório contém o código-fonte de uma Web API desenvolvida como parte do projeto de bloco da faculdade, cujo o objetivo éramos criar uma Web API em Java ou C#.

## Conteúdo:

- [Funcionalidades da API](#funcionalidades-da-api-gear)
- [Requisitos](#requisitos-books)
- [Configuração](#configuração-arrowforward)
- [Uso](#uso-pencil2)
- [Considerações finais](#considerações-finais-checkeredflag)

<br>

## Funcionalidades da API :gear:
A Web API desenvolvida possui as seguintes funcionalidades:

### CRUD de Hotel :pushpin:
- A API oferece operações CRUD para gerenciar os hotéis, incluindo a criação, leitura, atualização e exclusão de informações de cada hotel cadastrado.

### CRUD de Quarto :pushpin:
- A API oferece operações CRUD para gerenciar os quartos, incluindo a criação, leitura, atualização e exclusão de informações de cada quarto cadastrado.

### CRUD de Cliente :pushpin:
- A API oferece operações CRUD para gerenciar os clientes, incluindo a criação, leitura, atualização e exclusão de informações de cada cliente cadastrado.

### CRUD de Reserva :pushpin:
- A API oferece operações CRUD para gerenciar as reservas, incluindo a criação, leitura, atualização e exclusão de informações de cada reserva cadastrada.


### Boas práticas da API :ballot_box_with_check:
- A API segue as boas práticas de desenvolvimento de APIs, como tratamento de erros e respostas consistentes.

### Versionamento :hash:
- A API pode incluir versionamento, facilitando futuras atualizações sem quebrar a compatibilidade com as versões anteriores.

### Padronização :warning:
- O código da API segue convenções de nomenclatura e padronização, tornando-o legível e consistente para os desenvolvedores.

### Documentação (Swagger) :green_circle:
- A API é documentada usando o Swagger, facilitando o uso e entendimento por parte dos desenvolvedores.

<br>

## Requisitos :books:

Antes de iniciar o projeto, certifique-se de atender aos seguintes requisitos:

- [Visual Studio](https://visualstudio.microsoft.com/), [Visual Studio Code](https://code.visualstudio.com/) ou [Rider](https://www.jetbrains.com/pt-br/rider/download/)
- [.NET Core SDK](https://dotnet.microsoft.com/download) instalado na sua máquina.
- Um banco de dados compatível com (MySQL) configurado.
- Pacotes e dependências listados no arquivo `.csproj` instalados.

<br>

## Configuração :arrow_forward:
Siga as etapas abaixo para configurar e executar o projeto:

1. Clone este repositório:

   ```sh
   https://github.com/LLR798/trabalhos-da-faculdade.git

2. Acesse a pasta do projeto:
   ```sh
   cd EasyReserve/EasyReserve.API

3. Configure a conexão com o banco de dados no arquivo `appsettings.json`.

4. Execute o seguinte comando para aplicar as migrações e criar o banco de dados:
   ```sh
   dotnet ef database update

5. Inicie o projeto:
   ```sh
   dotnet run

A API estará disponível em `https://localhost:7273`.

<br>

## Uso :pencil2:
A API possui as seguintes rotas:

### Hotel:

- `POST /Hotel`: Cria um novo hotel.
- `PUT /Hotel/{id}`: Atualiza um hotel existente.
- `DELETE /Hotel/{id}`: Exclui um hotel existente.
- `GET /Hotel`: Obtém todos os hotéis cadastrados.
- `GET /Hotel/{id}`: Obtém um hotel pelo Id.

### Quarto:

- `POST /Room`: Cria um novo quarto.
- `PUT /Room/{id}`: Atualiza um quarto existente.
- `DELETE /Room/{id}`: Exclui um quarto existente.
- `GET /Room`: Obtém todos os quartos cadastrados.
- `GET /Room/{id}`: Obtém um quarto pelo Id.

### Cliente:

- `POST /Client`: Cria um novo cliente.
- `PUT /Client/{id}`: Atualiza um cliente existente.
- `DELETE /Client/{id}`: Exclui um cliente existente.
- `GET /Client`: Obtém todas os hotéis cadastrados.
- `GET /Client/{id}`: Obtém um cliente pelo Id.

### Reserva:

- `POST /Reserve`: Cria uma nova reserva.
- `PUT /Reserve/{id}`: Atualiza uma reserva existente.
- `DELETE /Reserve/{id}`: Exclui uma reserva existente.
- `GET /Reserve`: Obtém todas as reservas cadastradas.
- `GET /Reserve/{id}`: Obtém uma reserva pelo Id.


## Considerações finais :checkered_flag:

Este repositório contém a API completa desenvolvida como parte do trabalho final do bloco de back-end da faculdade de engenharia de software. A API oferece funcionalidades básicas e de nível Junior, seguindo as melhores práticas de desenvolvimento de software.
Divirta-se explorando e utilizando a API! Se tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato com a equipe de desenvolvimento.

Não se esqueça de deixar uma estrelinha no repositório :smiley:

© 2023 [Lucas Lumertz](https://lumertzdeveloper.netlify.app/)