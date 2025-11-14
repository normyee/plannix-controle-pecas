data_entrega ficou nula -> obra futura às vezes não tem data clara

renomeei os nomes das tabelas para ficarem mais claros
POBRAS -> obras
PJREGPROJETO -> pecas
LGACABAMENTO -> acabamentos
LGESTOQUE -> estoques

além disso acrescentei uma tabela nova chamada "regioes" para substituir o "Regiao" de acabamento e estoque. a razão foi a seguinte: e se eu quiser trocar a região do estoque ou acabamento? Teria que atualizar cada registro de estoque, por exemplo.

usei primary key composta para estoque para evitar duplicidade. poderia ter o mesmo id_peca e id_acabamento em um registro de estoque, mas fazendo ser a primary key isso é evitado

1 - Criação do Banco de Dados (SQL Server) ✅
1.1. Crie o banco de dados conforme o Diagrama de Dados fornecido. ✅
1.1.1. Considere que o Diagrama de Dados está incompleto e faça as correções e ajustes que julgar pertinentes. ✅
1.2. Desenvolva um script de INSERT para cada uma das tabelas especificadas no Diagrama de Dados. ✅
1.3. Elabore um script de SELECT que apresente, em uma única linha, as seguintes informações: Código de Controle; Nome da Peça; Nome da Obra; Status do Acabamento; Região de Estoque ✅

2 - Desenvolvimento de Sistema (C#)
2.1. Crie um sistema em C# Windows Forms com os seguintes requisitos:
2.1.1. O sistema deve conter pelo menos dois
formulários relacionados ao banco de dados criado na etapa anterior.
2.1.2. Implemente um CRUD com utilização de um DataGridView para listar os itens cadastrados.
2.1.3. Adicione filtros por Obra e Região de Estoque no sistema.
2.2. O sistema deve permitir a extração de um relatório em PDF com os cadastros realizados.
2.2.1. Inclua os filtros mencionados anteriormente (Obra e Região de Estoque) no relatório gerado.

Relacionamento:
```text
[obra] 1 ── n [peca] 1 ── n [acabamento] 1 ── 1 [estoque]
                    \                     /
                     \--- usa regiao ----/
```

# Setup do Banco de Dados
Você pode criar as tabelas de duas formas: pelo gerenciador de banco ou pelo Docker. Qualquer uma das opções funciona.

---

# Desafio 1
Você terá duas opções para seguir. Uma é executar pelo gerenciador de banco de dados, e a outra com o Docker. Subir o container do docker é opcional caso já tenha o banco de dados

## Opção 1: Com gerenciador de banco
Abra o script `script_create_tables.sql` em uma ferramenta como **Beekeeper Studio**, **DataGrip** ou **SQL Server Management Studio** com banco de dados já existente ou novo e execute ou copie o script, cole e execute. **Faça** o mesmo para `script_insert.sql` e `script_select.sql` de todas as etapas do **desafio 1**
> 1.1, 1.1.1, 1.2 e 1.3 ✅
---
## Opção 2: Com Docker

1. **Entre** no diretório `Scripts` do projeto.
2. Execute o script no container Docker:

```bash
docker run -it --rm -v "${PWD}:/scripts" --network host mcr.microsoft.com/mssql-tools bash -c "/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'ControlePecas@2025' -d master -i /scripts/script_create_tables.sql"
```
> 1.1 e 1.1.1 ✅
3. Verifique se as tabelas foram criadas
```bash
docker run -it --rm --network host mcr.microsoft.com/mssql-tools bash -c "/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'ControlePecas@2025' -d master -Q 'SELECT name FROM sys.tables;'"
```
4. Popular o banco de dados com items
```bash
docker run -it --rm -v "${PWD}:/scripts" --network host mcr.microsoft.com/mssql-tools bash -c "/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'ControlePecas@2025' -d master -i /scripts/script_insert.sql"

```
> 1.2 ✅
5. Selecionar linha com `código de controle`, `nome da peça`, `nome da obra`,`status do acabamento`, `região de estoque`
```bash
docker run -it --rm -v "${PWD}:/scripts" --network host mcr.microsoft.com/mssql-tools bash -c "/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'ControlePecas@2025' -d master -W -s '|' -i /scripts/script_select.sql"

```
> 1.3 ✅

---
# Desafio 2