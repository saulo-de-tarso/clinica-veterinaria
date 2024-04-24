# Case Ploomes - Super Hero API

## Resumo
Para este teste prático de C#, foi desenvolvida uma API conectada a um banco de dados SQL Server, ambos hospedados na Microsoft Azure.

## Conteúdo

-[Introdução](#introducao)    
-[Endpoints] (#endpoints)  
-[Modelos] (#modelos)  
-[Instruções para teste] (#instrucoes)  

## Introdução
A Super Hero API foi desenvovida para realizar alterações no banco de dados SQL da plataforma Super Hero CRM, através das operações CRUD (Criar, Ler, Atualizar e Apagar).    
No banco de dados existe uma tabela de clientes, a qual possui as seguintes propriedades: Id, Nome, CPF, Endereço e E-mail.  
É possível buscar a lista de clientes ou um cliente específico por Id, assim com atualizar e deletar um cliente por Id.  
Cada operação retorna um JSON contendo os dados retornados pela requisição, se a requisição foi um sucesso ou não, e uma mensagem caso a requisição falhe.

## Endpoints

### Adicionar cliente

O usuário informa dados de Nome, CPF, Endereço e E-mail, e a requisição armazena os dados no banco de dados.
O Id é incrementado de automaticamente pelo SQL conforme os usuários são adicionados.

- Método HTTP: POST
- Retorna: Lista em formato JSON com todos os clientes cadastrados na base de dados e suas propriedades, atualizada com o novo usuário inserido.

### Lista de clientes

- Método HTTP: GET
- Rota: api/Clientes
- Retorna: Lista em formato JSON com todos os clientes cadastrados na base de dados e suas propriedades.

### Dados do cliente por ID

O usuário informa o Id do cliente e são retornados os dados desse cliente.

- Método HTTP: GET
- Rota: api/Clientes/{id}
- Exceção: Se o Id do cliente não for encontrado, retorna uma mensagem informando o usuário.


### Atualizar cliente por ID

O usuário pode atualizar os dados do cliente informando o Id no corpo da requisição e os demais dados como Nome, CPF, Endereço e E-mail, e a requisição atualiza os dados no banco de dados.

- Método HTTP: PUT
- Retorna: Dados atualizados do cliente.
- Exceção: Se o Id do cliente não for encontrado, retorna uma mensagem informando o usuário.

### Excluir cliente por ID

O usuário pode excluir um cliente da base de dados, informando o Id no corpo da requisição.

- Método HTTP: DELETE
- Retorna: Lista em formato JSON com todos os clientes cadastrados na base de dados e suas propriedades, atualizada sem o usuário informado.
- Exceção: Se o Id do cliente não for encontrado, retorna uma mensagem informando o usuário.

## Modelos de dados

- Clientes
    - Id: Int
    - Nome: String
    - Cpf: string
    - Endereço: string
    - Email: string
        - Tabela no banco de dados: Clientes.

- ServiceResponse
    - Data: T
    - Success: bool
    - Message: string

- Obs.: o modelo de ServiceResponse é utilizado apenas para enviar informações ao front end. Caso a requisição falhe, informa uma mensagem ao usuário, e o atributo de sucesso vem como false. Do contrário, success = true e nenhuma mensagem é exibida.

## Migração de dados

A migração de dados foi feita utilizando code-first migration pelo Entity Framework Core. Através do modelo de clientes desenvolvido no C#, foi criada uma tabela de clientes na base de dados do SQL Server.

## Instruções para teste

As operações CRUD podem ser realizadas pelo swagger.

Clicando no link 1 é possível acessar o swagger da API, e clicando no link 2 é possível abrir o JSON da lista de clientes.

1. [Clique aqui para acessar o Swagger da API](https://caseploomes-api.azurewebsites.net/index.html)
2. [Clique aqui para acessar a lista de clientes](https://caseploomes-api.azurewebsites.net/api/clientes)




    





