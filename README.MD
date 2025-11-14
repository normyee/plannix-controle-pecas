data_entrega ficou nula -> obra futura às vezes não tem data clara

renomeei os nomes das tabelas para ficarem mais claros
POBRAS -> obras
PJREGPROJETO -> pecas
LGACABAMENTO -> acabamentos
LGESTOQUE -> estoques

além disso acrescentei uma tabela nova chamada "regioes" para substituir o "Regiao" de acabamento e estoque. a razão foi a seguinte: e se eu quiser trocar a região do estoque ou acabamento? Teria que atualizar cada registro de estoque, por exemplo.

usei primary key composta para estoque para evitar duplicidade. poderia ter o mesmo id_peca e id_acabamento em um registro de estoque, mas fazendo ser a primary key isso é evitado


Relacionamento:
```text
[obra] 1 ── n [peca] 1 ── n [acabamento] 1 ── 1 [estoque]
                    \                     /
                     \--- usa regiao ----/
```

# Setup do Banco de Dados
Você pode criar as tabelas de duas formas: pelo gerenciador de banco ou pelo Docker. Qualquer uma das opções funciona.

---

## Opção 1: Com gerenciador de banco
Abra o script `script_create_tables.sql` em uma ferramenta como **Beekeeper Studio**, **DataGrip** ou **SQL Server Management Studio** com banco de dados já existente ou novo e execute ou copie o script, cole e execute.

---
## Opção 2: Com Docker

1. Entre no diretório `Scripts` do projeto.
2. Execute o script no container Docker:

```bash
docker run -it --rm -v "${PWD}:/scripts" --network host mcr.microsoft.com/mssql-tools bash -c "/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'ControlePecas@2025' -d master -i /scripts/script_create_tables.sql"
```
3. Verifique se as tabelas foram criadas
```bash
docker run -it --rm --network host mcr.microsoft.com/mssql-tools bash -c "/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'ControlePecas@2025' -d master -Q 'SELECT name FROM sys.tables;'"
```