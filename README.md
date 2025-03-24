# 📌  HelpApp

Um aplicativo de gestão de atendimentos voluntários, desenvolvido com arquitetura limpa e princípios sólidos da engenharia de software.

## 📚  Descrição Geral

O HelpApp é um sistema para organizar atendimentos voluntários, focado em facilitar o encontro entre quem precisa de ajuda e quem pode ajudar. O projeto foi construído utilizando a plataforma .NET Core, com persistência em SQL Server e implantação na nuvem via Azure Server Apps. Toda a lógica foi projetada com base em princípios de desenvolvimento sustentável e manutenção facilitada, utilizando os conceitos do SOLID.

### O que o sistema HelpApp realiza

- Conecta voluntários com pessoas que necessitam de ajuda.
- Gerencia e organiza os atendimentos de forma eficiente.
- Fornece ferramentas para agendamento e acompanhamento das ações.

### Qual problema resolve

- Dificuldade em encontrar e organizar atendimentos voluntários.
- Falta de comunicação eficiente entre voluntários e solicitantes.
- Necessidade de um sistema centralizado para gerenciar as ações.

### Quem são os usuários (público-alvo)

- Voluntários que desejam oferecer ajuda.
- Pessoas que necessitam de auxílio em diversas áreas.
- Organizações que coordenam ações voluntárias.

### Tecnologias Utilizadas:

- Linguagem: C# (.NET Core)
- Banco de Dados: SQL Server
- Ambiente: Azure App Services
- IDE: Visual Studio / VS Code
- ORM: Entity Framework Core
- Testes: xUnit ou NUnit
- Controle de Versão: Git + GitHub

##  🧪 Funcionalidades

- Cadastro de usuários (ajudante e solicitante).
- Registro e gerenciamento de atendimentos.
- Agenda personalizada.
- Histórico e relatórios de ações.
- Login seguro com autenticação e autorização.

## ️🏗️ Arquitetura do Projeto

O projeto HelpApp foi desenvolvido utilizando a arquitetura limpa, com as seguintes camadas:

- **Domain**: Camada de domínio, que contém as entidades e regras de negócio.
- **Application**: Camada de aplicação, que coordena os casos de uso.
- **Infrastructure**: Camada de infraestrutura, que lida com a persistência e serviços externos.
- **Interface**: Camada de interface, que expõe os endpoints da API.

A arquitetura segue os princípios do DDD (Domain-Driven Design) e Clean Architecture, garantindo um código organizado, testável e de fácil manutenção.

## ⚙️ Princípios SOLID Aplicados

No desenvolvimento do HelpApp, a aplicação dos princípios SOLID foi fundamental para garantir um código limpo, organizado e de fácil manutenção. Cada um dos cinco princípios foi cuidadosamente considerado e implementado da seguinte forma:

### 5.1. S - Single Responsibility Principle (Princípio da Responsabilidade Única)

- **Descrição**: Este princípio afirma que uma classe deve ter apenas um motivo para mudar, ou seja, uma única responsabilidade.
- **Aplicação no HelpApp**:
  - A classe `UserManager`, por exemplo, foi projetada exclusivamente para lidar com a criação e atualização de usuários. Ela não se preocupa com o agendamento de atendimentos ou com a lógica de autenticação.
  - Ao separar as responsabilidades, garantimos que qualquer alteração na lógica de usuários não afete outras partes do sistema, e vice-versa. Isso torna o código mais modular e fácil de testar.

### 5.2. O - Open/Closed Principle (Princípio Aberto/Fechado)

- **Descrição**: Este princípio estabelece que uma classe deve estar aberta para extensão, mas fechada para modificação.
- **Aplicação no HelpApp**:
  - Utilizamos interfaces como `IUserRepository` e `IAttendanceService` para definir contratos. Novas implementações dessas interfaces podem ser adicionadas sem modificar o código existente.
  - Por exemplo, se precisarmos adicionar um novo tipo de repositório de usuários (além do SQL Server), podemos criar uma nova classe que implementa `IUserRepository` sem alterar o código que utiliza essa interface.

### 5.3. L - Liskov Substitution Principle (Princípio da Substituição de Liskov)

- **Descrição**: Este princípio afirma que subclasses devem ser substituíveis por suas classes base sem alterar o comportamento correto do programa.
- **Aplicação no HelpApp**:
  - Os serviços de notificação `EmailNotifier` e `SmsNotifier` herdam de uma interface comum, como `INotifier`. Ambos podem ser usados de forma intercambiável sem quebrar a funcionalidade de notificação.
  - Isso significa que, em qualquer lugar do código onde `INotifier` é usado, podemos substituir por `EmailNotifier` ou `SmsNotifier` sem causar erros.

### 5.4. I - Interface Segregation Principle (Princípio da Segregação de Interfaces)

- **Descrição**: Este princípio defende que interfaces específicas são melhores do que interfaces genéricas.
- **Aplicação no HelpApp**:
  - Em vez de uma única interface grande, criamos interfaces menores e mais focadas, como `ILoginService` e `IAgendaManager`.
  - Isso evita que uma classe precise implementar métodos que não utiliza. Por exemplo, uma classe que lida com o login não precisa implementar métodos de agendamento.

### 5.5. D - Dependency Inversion Principle (Princípio da Inversão de Dependência)

- **Descrição**: Este princípio afirma que módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.
- **Aplicação no HelpApp**:
  - A camada de aplicação depende de interfaces (abstrações) e não de implementações concretas, como o SQL Server ou o .NET.
  - Isso torna o código mais flexível e testável. Podemos substituir facilmente as implementações de baixo nível sem alterar a camada de aplicação. Por exemplo, podemos trocar o SQL Server por outro banco de dados sem modificar a lógica de negócios.

##  🔧 Como Rodar o Projeto

1. Clone o repositório:
   ```bash
   git clone [https://github.com/seu-usuario/helpapp.git](https://github.com/seu-usuario/helpapp.git)
2.	Abra o projeto no Visual Studio.
3.	Configure a string de conexão no arquivo appsettings.json.
4.	Execute o comando Update-Database no Package Manager Console para aplicar as migrations.
“Update-Database”
5.	Execute a aplicação (F5 ou dotnet run).
6.	Teste as rotas da API utilizando o Postman ou Swagger

##  🧪 Testes Automatizados
- Testes unitários foram implementados para as camadas Domain e Application. 
-  Os testes podem ser executados utilizando o comando dotnet test. 
-  A cobertura de testes prioriza as regras de negócio e casos de uso principais.
  
## 📂 Estrutura de Pastas
 HelpApp/ 
- Domain/
  - Entities/
  - Interfaces/
- Application/
  - UseCases/
- Infrastructure/
  - Data/
  - Servides/
- Interface/
  - Controllers/
- Tests/
- Program.cs
  
## Logotipo da aplicação:
![2](https://github.com/user-attachments/assets/166f3752-084c-487c-9b97-4f984b190524)

## 👨‍💻 Autores
- Nome Completo: Clara Domitila Chence
- Git Hub: @clarachence

## 📜 Licença
Este projeto está licenciado sob a MIT License 
