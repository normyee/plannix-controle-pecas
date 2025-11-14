INSERT INTO obras (nome_obra, sigla_obra, data_entrega, status)
VALUES 
    ('residencial ipê', 'IPE', '2025-12-10', 'ATIVA'),
    ('condomínio jardins', 'JAR', '2026-03-01', 'ATIVA');

INSERT INTO regioes (nome_regiao, tipo_regiao)
VALUES
    ('setor 1', 'acabamento'),
    ('setor 2', 'acabamento'),
    ('galpão a', 'estoque'),
    ('galpão b', 'estoque');

INSERT INTO pecas (nome_peca, data, volume_mcub, peso_kg, status, id_obra)
VALUES
    ('viga a23', '2025-01-10', 1.20, 300, 'PRODUZIDA', 1),
    ('pilar b14', '2025-01-12', 0.80, 220, 'PRODUZIDA', 1),
    ('laje l30', '2025-02-01', 2.50, 500, 'EM PRODUCAO', 2),
    ('viga a45', '2025-01-15', 1.40, 330, 'PRODUZIDA', 1),
    ('pilar c09', '2025-01-18', 0.75, 210, 'PRODUZIDA', 1),
    ('painel p55', '2025-01-20', 3.10, 620, 'EM PRODUCAO', 1),
    ('laje l22', '2025-02-05', 2.10, 430, 'PENDENTE', 2),
    ('viga a12', '2025-01-09', 1.00, 280, 'PRODUZIDA', 1),
    ('pilar d07', '2025-02-03', 0.95, 250, 'EM PRODUCAO', 2),
    ('painel p33', '2025-02-10', 2.80, 570, 'PENDENTE', 2),
    ('base b10', '2025-01-25', 1.90, 410, 'PRODUZIDA', 1),
    ('sapata s03', '2025-01-27', 3.80, 760, 'EM PRODUCAO', 2),
    ('módulo m18', '2025-02-12', 1.60, 340, 'PRODUZIDA', 1),
    ('viga a51', '2025-02-14', 1.55, 350, 'EM PRODUCAO', 2),
    ('pilar e11', '2025-02-16', 0.88, 230, 'PRODUZIDA', 1);

INSERT INTO acabamentos (id_peca, data, status, id_regiao)
VALUES
    (1, '2025-01-15', 'FINALIZADO', 1),
    (2, '2025-01-16', 'EM ANDAMENTO', 2),
    (3, '2025-02-05', 'PENDENTE', 1);

INSERT INTO estoques (id_peca, id_acabamento, data, status, id_regiao)
VALUES
    (1, 1, '2025-01-20', 'ARMAZENADO', 3),
    (2, 2, '2025-01-22', 'ARMAZENADO', 4);