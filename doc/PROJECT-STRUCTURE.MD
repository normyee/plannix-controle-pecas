# Decisões arquiteturais e estrutura do projeto

Este projeto é um sistema Windows Forms para controle de peças no contexto de pré-fabricados. Adota uma arquitetura baseada em View Model e se inspira com alguns princípios de **Clean Architecture** e **Vertical Slice Architecture**, incorporando **Repositories**, **Features** e **View models** para organizar a lógica de negócio e a apresentação de dados.

## requisitos para rodar este projeto

#### Setup de ambiente

- visual studio 2022 ou superior
- .NET 4.8 ou superior
- SQL Server (ou docker para subir a imagem)

#### Como executar em sua máquina?

- Siga as instruções no README.MD para subir uma imagem docker com SQL Server ou executar as queries em um gerenciador de banco.

## Estrutura do projeto

- `src/Application`: camada de aplicação, contém a lógica de negócio e regras de manipulação de dados

  - `Entities`: entidades do domínio, como `Peca`, `Acabamento`, `Estoque`, `Obra`, etc.
  - `Features`: casos de uso ou serviços que manipulam as entidades
  - `Repositories`: Implementações de acesso a dados

- `src/UI/Forms`: Camada de UI com os formulários

  - `ControleAtualizacao.cs`: Formulário para atualização de peças
  - `ControleCriacao.cs`: Formulário para criação de novas peças
  - `Main.cs`: Formulário principal do sistema

- `src/UI/ViewModels`: View models que conectam a UI às entidades

  - `PecaViewModel.cs`: view model de peça, usado para binding com os formulários

- `src/UI/Resources`: recursos da aplicação, como imagens, ícones e arquivos estáticos

- `Main.cs`: ponto de entrada do sistema

## Decisões importantes

- **View models** foram utilizados para separar lógica de apresentação da lógica de negócio.
- **Modal** em vez de panels para inserção/atualização de peças, garantindo melhor experiência de navegação.
- **Primary key composta** em estoque para evitar duplicidades.
- mapeamento de status entre acabamento e estoque:
  - `PENDENTE` → `AGUARDANDO_ACABAMENTO`
  - `EM_PRODUCAO` → `EM_ACABAMENTO`
  - `FINALIZADO` → `DISPONIVEL`
- Aplicação de **inversão de dependências** para facilitar testes e manutenção.
- Docker pode ser usado para provisionar o sql server isoladamente.
