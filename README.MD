data_entrega ficou nula -> obra futura às vezes não tem data clara

renomeei os nomes das tabelas para ficarem mais claros
POBRAS -> obras
PJREGPROJETO -> pecas
LGACABAMENTO -> acabamentos
LGESTOQUE -> estoques

além disso acrescentei uma tabela nova chamada "regioes" para substituir o "Regiao" de acabamento e estoque. a razão foi a seguinte: e se eu quiser trocar a região do estoque ou acabamento? Teria que atualizar cada registro de estoque, por exemplo.

usei primary key composta para estoque para evitar duplicidade. poderia ter o mesmo id_peca e id_acabamento em um registro de estoque, mas fazendo ser a primary key isso é evitado



relacionamento:
obra (1) -------- (n) peca (1) -------- (n) acabamento (1) -------- (1) estoque
                                   \                             /
                                    \---------------------------/
                                           usa regiao



setup do banco de dados

opção 1: executar com sqlcmd direto do container

opção 2: executar direto de um gerenciador de banco de dados (como beekeeper studio, datagrip ou sql server management studio)