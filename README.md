# ⚖️ Dra. Thaenna Bruna – Advocacia Especializada

> Site institucional para escritório de advocacia, com backend em ASP.NET Core e deploy automático no Azure.

## 🌐 Demonstração

> 🚧 O deploy ao vivo foi desativado (estava no Azure via conta de estudante). Em breve o projeto será hospedado novamente — enquanto isso, veja os prints abaixo ou rode localmente com as instruções da seção "Como executar".

## 🚀 Funcionalidades

- Apresentação institucional do escritório e da advogada
- Páginas dedicadas para cada área de atuação (Direito Civil, Empresarial, Família, Imobiliário, Sucessões, Conflitos)
- Blog com listagem e leitura de artigos
- Layout responsivo, com animações e interatividade sutil
- Design adaptado para desktop e dispositivos móveis

## 🛠️ Tecnologias utilizadas

![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=flat&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=flat&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=flat&logo=javascript&logoColor=black)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=flat&logo=bootstrap&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![Azure](https://img.shields.io/badge/Azure-0078D4?style=flat&logo=microsoftazure&logoColor=white)
![GitHub Actions](https://img.shields.io/badge/GitHub_Actions-2088FF?style=flat&logo=githubactions&logoColor=white)

- **HTML5** — Estrutura semântica
- **CSS3** — Estilização customizada
- **JavaScript** — Interatividade e animações
- **Bootstrap 5.3.2** — Framework CSS responsivo
- **C# / ASP.NET Core (Razor Pages)** — Backend
- **Azure App Service** — Hospedagem
- **GitHub Actions** — CI/CD (deploy automático a cada push)

## 📁 Estrutura do projeto

```
TB/
├── Models/                # Classes de dados e modelos da aplicação
├── Pages/                 # Razor Pages (.cshtml + .cshtml.cs)
│   ├── areasAtuacao/      # Páginas de áreas de atuação
│   ├── Blog/              # Blog e exibição de artigos
│   └── Shared/            # Layouts e componentes compartilhados
├── Services/              # Regras de negócio e serviços
├── Properties/            # Configurações do projeto
├── wwwroot/               # Arquivos estáticos (css, js, img)
├── Program.cs             # Ponto de entrada da aplicação
├── TB.csproj              # Projeto .NET
└── TB.sln                 # Solution do projeto
```

## ▶️ Como executar localmente

**Pré-requisitos:**
- .NET SDK 6.0 ou superior
- Visual Studio, VS Code ou Rider

**Passos:**

```bash
# Clone o repositório
git clone https://github.com/EmanuelVieiira/AdvogadaThaennaBruna.git
cd AdvogadaThaennaBruna

# Restaure as dependências
dotnet restore

# Execute a aplicação
dotnet run
```

Acesse em `https://localhost:5001` ou `http://localhost:5000`.

## 🎯 Objetivo

Projeto prático desenvolvido para aplicar conceitos de backend com C#/ASP.NET Core em um site real, incluindo estruturação em Razor Pages, organização em camadas (Models/Services/Pages) e deploy contínuo em nuvem via Azure e GitHub Actions.

## 📄 Licença

© 2025 Dra. Thaenna Bruna – Todos os direitos reservados.
