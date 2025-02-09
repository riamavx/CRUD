# Especificação do Projeto de Sistema Financeiro
## Visão Geral
O projeto consiste em desenvolver uma API em .NET 8 para gerenciar um sistema financeiro que permite a criação e gestão de clientes e tipos de contas. A API fornecerá endpoints para operações CRUD (Create, Read, Update, Delete) e outras funcionalidades relacionadas a clientes e contas.

## Entidades e Relacionamentos
### 1. Cliente
  - Id: Identificador único do cliente (Guid).
  - Nome: Nome completo do cliente (string).
  - CPF: Número do CPF do cliente (string, único).
  - DataNascimento: Data de nascimento do cliente (DateTime).
  - Endereco: Endereço do cliente (string).
  - Telefone: Número de telefone do cliente (string).
  - Email: Endereço de e-mail do cliente (string, único).
  - DataCadastro: Data de cadastro do cliente (DateTime).

### 2. Tipo de Conta
  - Id: Identificador único do tipo de conta (Guid).
  - Nome: Nome do tipo de conta (string, ex: "Conta Corrente", "Conta Poupança").
  - Descricao: Descrição do tipo de conta (string).

### 3. Conta
  - Id: Identificador único da conta (Guid).
  - NumeroConta: Número da conta (string, único).
  - Saldo: Saldo atual da conta (decimal).
  - DataAbertura: Data de abertura da conta (DateTime).
  - ClienteId: Identificador do cliente associado à conta (Guid, chave estrangeira para Cliente).
  - TipoContaId: Identificador do tipo de conta associado à conta (Guid, chave estrangeira para TipoConta).

## Relacionamentos
  - Um Cliente pode ter várias Contas.
  - Uma Conta pertence a um único Cliente.
  - Uma Conta está associada a um único Tipo de Conta.

## Funcionalidades da API
### 1. Clientes
  - GET /api/clientes: Retorna uma lista de todos os clientes.
  - GET /api/clientes/{id}: Retorna os detalhes de um cliente específico.
  - POST /api/clientes: Cria um novo cliente.
  - PUT /api/clientes/{id}: Atualiza os dados de um cliente existente.
  - DELETE /api/clientes/{id}: Remove um cliente.

### 2. Tipos de Conta
  - GET /api/tiposconta: Retorna uma lista de todos os tipos de conta.
  - GET /api/tiposconta/{id}: Retorna os detalhes de um tipo de conta específico.
  - POST /api/tiposconta: Cria um novo tipo de conta.
  - PUT /api/tiposconta/{id}: Atualiza os dados de um tipo de conta existente.
  - DELETE /api/tiposconta/{id}: Remove um tipo de conta.

### 3. Contas
  - GET /api/contas: Retorna uma lista de todas as contas.
  - GET /api/contas/{id}: Retorna os detalhes de uma conta específica.
  - POST /api/contas: Cria uma nova conta.
  - PUT /api/contas/{id}: Atualiza os dados de uma conta existente.
  - DELETE /api/contas/{id}: Remove uma conta.
  - GET /api/clientes/{clienteId}/contas: Retorna todas as contas de um cliente específico.

### 4. Operações Financeiras
  - POST /api/contas/{id}/deposito: Realiza um depósito em uma conta.
  - POST /api/contas/{id}/saque: Realiza um saque em uma conta.
  - POST /api/contas/{id}/transferencia: Realiza uma transferência entre contas.

## Exemplos de Requisições e Respostas

### Exemplo 1: Criar um Cliente

Requisição:
```
POST /api/clientes
Content-Type: application/json

{
  "nome": "João Silva",
  "cpf": "123.456.789-00",
  "dataNascimento": "1980-01-01",
  "endereco": "Rua das Flores, 123",
  "telefone": "(11) 98765-4321",
  "email": "joao.silva@example.com"
}
```

Resposta:
```
HTTP/1.1 201 Created
Content-Type: application/json

{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "nome": "João Silva",
  "cpf": "123.456.789-00",
  "dataNascimento": "1980-01-01",
  "endereco": "Rua das Flores, 123",
  "telefone": "(11) 98765-4321",
  "email": "joao.silva@example.com",
  "dataCadastro": "2023-10-01T12:00:00Z"
}
```

### Exemplo 2: Realizar um Depósito

Requisição:
```
POST /api/contas/550e8400-e29b-41d4-a716-446655440000/deposito
Content-Type: application/json

{
  "valor": 1000.00
}
```

Resposta:
```
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "numeroConta": "123456",
  "saldo": 2000.00,
  "dataAbertura": "2023-10-01T12:00:00Z",
  "clienteId": "550e8400-e29b-41d4-a716-446655440000",
  "tipoContaId": "550e8400-e29b-41d4-a716-446655440001"
}
```
