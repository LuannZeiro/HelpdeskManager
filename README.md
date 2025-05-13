# HelpdeskManager

Sistema de controle de chamados internos de TI desenvolvido em .NET 7, com integração ao banco de dados Oracle usando Entity Framework Core.

## 📌 Objetivo

Gerenciar chamados de suporte técnico, permitindo operações de criação, leitura, atualização e exclusão (CRUD) via API REST.

---

## 🧩 Estrutura da Solução

- **HelpdeskManager.API**: Projeto principal da API.
- **HelpdeskManager.Domain**: Entidades do domínio (ex: `Chamado`).
- **HelpdeskManager.Application**: Regras de negócio (em branco neste exemplo).
- **HelpdeskManager.Infrastructure**: Conexão com o banco de dados (EF Core + Oracle).

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core 7
- Entity Framework Core
- Oracle Database
- Swagger (OpenAPI)
- RESTful API

---

## 🔗 Endpoints Disponíveis

- `GET /api/chamados` – Lista todos os chamados.
- `POST /api/chamados` – Cria um novo chamado.
- `PUT /api/chamados/{id}` – Atualiza um chamado existente.
- `DELETE /api/chamados/{id}` – Remove um chamado.

---

## ⚙️ Instalação e Execução

1. **Clonar o repositório**:
   ```bash
   git clone <url-do-repo>
   cd HelpdeskManager
