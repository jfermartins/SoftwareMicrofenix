# SoftwareMicrofenix

Este repositório contém o projeto **SoftwareMicrofenix**, um sistema desenvolvido como Trabalho de Conclusão de Curso (TCC) durante o curso técnico em informática. O objetivo principal deste software é demonstrar conhecimentos em programação de sistemas, gerenciamento de banco de dados e desenvolvimento de interfaces gráficas de usuário (GUI).




## Propósito do Projeto

O Software Microfenix foi concebido para simular um sistema de gestão educacional ou administrativa, abrangendo diversas funcionalidades essenciais para o dia a dia de uma instituição. Ele serve como uma prova prática das habilidades adquiridas no desenvolvimento de software, incluindo a criação de uma aplicação robusta e interativa.

## Funcionalidades Principais

O sistema oferece uma gama de funcionalidades, divididas por perfis de usuário (Administrador, Administração, Diretoria, Técnico, RH, Professor, Secretaria), conforme pode ser observado na análise do código-fonte (`Acesso.vb`). Algumas das principais funcionalidades incluem:

*   **Gestão de Funcionários:** Cadastro, busca e alteração de dados de funcionários.
*   **Gestão de Disciplinas:** Cadastro, busca e atualização/exclusão de disciplinas.
*   **Gestão de Atividades:** Cadastro e busca de atividades, além da atribuição de notas e faltas.
*   **Gestão de Alunos:** Cadastro, matrícula e busca de alunos.
*   **Gestão de Laboratórios:** Cadastro de laboratórios e registro de ocorrências.
*   **Gestão de Cronogramas:** Cadastro, busca e alteração de cronogramas de salas.
*   **Gestão de Materiais:** Cadastro e busca de materiais.
*   **Controle de Acesso:** Sistema de login com diferentes níveis de permissão baseados no cargo do funcionário.

Essas funcionalidades são acessadas através de uma interface MDI (Multiple Document Interface), onde cada funcionalidade é aberta como uma janela filha dentro da janela principal (`Principal.vb`).




## Tecnologias Utilizadas

O Software Microfenix foi desenvolvido utilizando as seguintes tecnologias:

*   **Visual Basic .NET (VB.NET):** Linguagem de programação principal para o desenvolvimento da aplicação desktop, aproveitando o framework .NET para a criação da interface gráfica e lógica de negócios.
*   **SQL Server:** Sistema de gerenciamento de banco de dados relacional (SGBD) utilizado para armazenar e gerenciar todas as informações do sistema, como dados de funcionários, alunos, disciplinas, atividades, notas, etc. A interação com o banco de dados é realizada através de `SqlCommand` e `SqlDataReader`, utilizando *Stored Procedures* para operações de login e outras interações, conforme pode ser visto no arquivo `Acesso.vb`.

## Estrutura do Projeto

O repositório está organizado da seguinte forma:

*   `Sln_Microfênix.sln`: Arquivo de solução do Visual Studio, que organiza o projeto.
*   `Sln_Microfênix/`: Diretório principal do projeto, contendo todos os arquivos de código-fonte e recursos.
    *   `*.vb`: Arquivos de código-fonte em Visual Basic .NET, representando as diferentes telas (formulários) e módulos do sistema (ex: `Principal.vb`, `Acesso.vb`, `CadastrarFuncionario.vb`, etc.).
    *   `*.designer.vb`: Arquivos gerados automaticamente pelo Visual Studio que definem o layout e os componentes visuais dos formulários.
    *   `*.resx`: Arquivos de recursos associados aos formulários, contendo strings, imagens e outros recursos.
    *   `App.config`: Arquivo de configuração da aplicação.
    *   `Sln_Microfênix.vbproj`: Arquivo de projeto do Visual Basic .NET.

## Como Executar o Projeto

Para configurar e executar o SoftwareMicrofenix, siga os passos abaixo:

1.  **Pré-requisitos:**
    *   Visual Studio (versão compatível com .NET Framework 4.5 ou superior).
    *   SQL Server (Express, Developer ou Standard) instalado e configurado.

2.  **Clonar o Repositório:**
    ```bash
    git clone https://github.com/jfermartins/SoftwareMicrofenix.git
    cd SoftwareMicrofenix
    ```

3.  **Configurar o Banco de Dados:**
    *   Crie um banco de dados no SQL Server chamado `MICROFENIX`.
    *   Os scripts SQL necessários para criar o banco de dados, tabelas e *Stored Procedures* podem ser encontrados no seguinte repositório: [https://github.com/jfermartins/SQL](https://github.com/jfermartins/SQL). Execute-os no seu SQL Server.
    *   Atualize a string de conexão no arquivo `Acesso.vb` (linha 16) para corresponder à sua configuração do SQL Server. Exemplo:
        ```vb.net
        Dim str As String = "Server=SEU_SERVIDOR;Database=MICROFENIX;User Id=SEU_USUARIO;Password=SUA_SENHA;"
        ```

4.  **Abrir no Visual Studio:**
    *   Abra o arquivo `Sln_Microfênix.sln` no Visual Studio.

5.  **Compilar e Executar:**
    *   Compile o projeto (`Build > Build Solution`).
    *   Execute a aplicação (`Debug > Start Debugging` ou pressione `F5`).

## Contribuição

Este projeto foi desenvolvido como parte de um TCC e não está aberto a contribuições externas no momento. No entanto, sinta-se à vontade para fazer um *fork* e adaptá-lo para seus próprios estudos ou projetos.


## Autor

**Jane Fernanda Martins**

*   [Linkedin Profile](https://linkedin.com/in/jfermartins)
