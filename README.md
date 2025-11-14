
# ⚖️ Dra. Thaenna Bruna - Advocacia Especializada

> Profissionalismo, confiança e excelência em serviços jurídicos.

Um site moderno para apresentar os serviços da Dra. Thaenna Bruna e facilitar o contato com clientes.

---
## 🌐 Visualização Online

🔗 **[Ver site ao vivo](https://emanuelwebapp-adaxe5dwhxf0f5cv.brazilsouth-01.azurewebsites.net)**

> O site está hospedado no **Azure App Service**, com deploy automático via GitHub Actions a cada push na branch principal.

---

## 📋 Sobre o Projeto

Projeto prático de programação desenvolvido para atender todos os requisitos da **Dra. Thaenna Bruna**, apresentando seus serviços jurídicos, áreas de atuação e informações de contato. O site foi construído com design moderno e responsivo, garantindo excelente experiência em desktops e dispositivos móveis, e inclui interatividade e animações sutis para melhorar a experiência do usuário.
---

## 🚀 Tecnologias Utilizadas

![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=flat&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=flat&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=flat&logo=javascript&logoColor=black)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=flat&logo=bootstrap&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)

- **HTML5** – Estrutura semântica  
- **CSS3** – Estilização customizada  
- **JavaScript** – Interatividade e animações  
- **Bootstrap 5.3.2** – Framework CSS responsivo  
- **Google Fonts** – Tipografia (Roboto)  
- **C# / .NET** – Backend  

---

## 👥 Equipe

Desenvolvido por uma equipe de 3 estudantes dedicados:

| Membro | Função | GitHub | LinkedIn |
|--------|--------|--------|----------|
| **Membro 1** | Design e HTML/CSS | [@Emanuelvieira](https://github.com/EmanuelVieiira) | [link](https://linkedin.com/in/seulink) |
| **Membro 2** | JavaScript e Integrações | [@username2](https://github.com/username2) | [link](https://linkedin.com/in/link2) |
| **Membro 3** | Backend em C# e Deploy | [@username3](https://github.com/username3) | [link](https://linkedin.com/in/link3) |

**Orientador(a):** Daniel Ferreira.

---

## 📁 Estrutura do Projeto
```
TB/
├── 📁 Models/                       # Classes de dados e modelos da aplicação
│   └── Article.cs
│
├── 📁 Pages/                        # Razor Pages (.cshtml + .cshtml.cs)
│   ├── 📁 areasAtuacao/            # Páginas de áreas de atuação
│   │   ├── conflitos.cshtml
│   │   ├── direitoCivil.cshtml
│   │   ├── direitoEmpresarial.cshtml
│   │   ├── direitoFamilia.cshtml
│   │   ├── direitoImobiliario.cshtml
│   │   └── sucessoes.cshtml
│   │
│   ├── 📁 Blog/                     # Blog e exibição de artigos
│   │   ├── Index.cshtml
│   │   ├── Index.cshtml.cs
│   │   ├── Article.cshtml
│   │   └── Article.cshtml.cs
│   │
│   ├── 📁 Shared/                   # Layouts e partes compartilhadas
│   │   ├── _Header.cshtml
│   │   ├── _Footer.cshtml
│   │   └── _Layout.cshtml
│   │
│   ├── Index.cshtml                 # Página inicial
│   └── Index.cshtml.cs
│
├── 📁 Services/                     # Regras de negócio e serviços
│   └── ArticleRepository.cs
│
├── 📁 Properties/                   # Configurações do projeto
│   └── launchSettings.json
│
├── 📁 wwwroot/                      # Arquivos estáticos acessíveis pelo navegador
│   ├── 📁 css/                      # Estilos CSS
│   │   ├── style.css
│   │   ├── animations.css
│   │   ├── lendoBlog.css
│   │   ├── blog.css
│   │   ├── carousel-override.css
│   │   ├── 📁 areas/                # CSS das páginas de áreas de atuação
│   │   └── 📁 layout/               # Header, footer, section, layout
│   │
│   ├── 📁 img/                      # Imagens usadas no site
│   │
│   └── 📁 js/                       # Scripts JavaScript
│       ├── main.js
│       └── blogFilter.js
│
├── ⚙️ .gitignore                    # Arquivos e pastas ignorados pelo Git
├── ⚙️ appsettings.json              # Configurações da aplicação
├── ⚙️ appsettings.Development.json  # Configurações específicas de dev
├── 💻 Program.cs                    # Ponto de entrada da aplicação
├── 📄 TB.csproj                     # Projeto .NET
└── 📄 TB.sln                        # Solution do projeto


````
---


## 🛠️ Como Executar

**Pré-requisitos:**

- .NET SDK 6.0 ou superior  
- Visual Studio, VS Code ou Rider  

**Passos:**

1. Clone o repositório:

```bash
git clone [url-do-repositorio]
cd TB
````
Restaure as dependências:
```bash
dotnet restore
````
Execute a aplicação:
```bash
dotnet run
```

Acesse no navegador:

https://localhost:5001
ou
http://localhost:5000

## 📄 Licença

© 2025 Dra. Thaenna Bruna – Todos os direitos reservados


