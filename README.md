

## 🧠 Backend - Gestão de Pedidos (.NET 8 + PostgreSQL + Azure Service Bus)

Este projeto representa a API do sistema de Gestão de Pedidos, desenvolvida em **ASP.NET Core 8**, utilizando **PostgreSQL** como banco de dados e **Azure Service Bus** para mensageria. O ambiente está totalmente conteinerizado com **Docker**.

---

### 📁 Estrutura do Projeto

| Pasta            | Descrição                                             |
| ---------------- | ----------------------------------------------------- |
| `Context`        | Configuração do banco de dados e `DbContext`.         |
| `Controllers`    | Endpoints da API.                                     |
| `Migrations`     | Migrações do Entity Framework.                        |
| `Models`         | Modelos das entidades.                                |
| `Repository`     | Interfaces dos repositórios.                          |
| `RepositoryImpl` | Implementações dos repositórios.                      |
| `Service`        | Lógica de negócio.                                    |
| `Views`          | (Opcional) Suporte para visualizações, se necessário. |
| `Properties`     | Configurações do projeto.                             |

---

### 🚀 Como Executar com Docker Compose

1. **Clone o projeto:**

```bash
git clone https://github.com/alisson-C-angular-php/gestao_pedidos_back.git
cd gestao_pedidos_back
```

2. **Execute com Docker Compose:**

```bash
docker-compose up --build
```

> Isso iniciará:
>
> * API ASP.NET em `http://localhost:5000`
> * Banco PostgreSQL na porta `5435`
> * Serviço de mensageria conectado via Azure Service Bus

---

### ⚙️ Configurações Importantes

O arquivo `appsettings.json` contém as **credenciais sensíveis**. Edite conforme suas credenciais:

```json

"AzureServiceBus": {
  "ConnectionString": "your-service-bus-connection-string",
  "QueueName": "your-queue-name"
}
```


---

### 📦 Dependências

* .NET 8
* PostgreSQL
* Azure Service Bus (Queue)
* Docker / Docker Compose

---

### 📬 Endpoints de Exemplo

| Método | Endpoint            | Descrição        |
| ------ | ------------------- | ---------------- |
| GET    | `/api/orders`      | Lista pedidos    |
| POST   | `/api/orders`      | Cria novo pedido |
| DELETE | `/api/orders/{id}` | Lista pedido por id    |

> 📌 Os endpoints reais dependem dos controllers definidos na pasta `Controllers`.

---

### 🛠️ Comandos Úteis (Desenvolvimento)

```bash
# Restaurar pacotes
dotnet restore

# Executar localmente
dotnet run

# Aplicar migrações (se necessário)
dotnet ef database update
```

---

