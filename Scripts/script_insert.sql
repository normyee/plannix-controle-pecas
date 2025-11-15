INSERT INTO obras (nome_obra, sigla_obra, data_entrega, status)
VALUES 
    ('residencial ipê', 'IPE', '2025-12-10', 'CONCLUIDA'),
    ('prédio arranha-céus', 'ARC', '2025-11-22', 'CONCLUIDA'),
    ('condomínio jardins', 'JAR', '2026-03-01', 'ATIVA'),
    ('ponte amizade', 'PAM', '2024-04-10', 'INATIVA');

INSERT INTO regioes (nome)
VALUES
    ('setor 1'),   
    ('setor 2'),   
    ('galpão a'),     
    ('galpão b');     

INSERT INTO pecas (nome_peca, data, volume_mcub, peso_kg, status, id_obra)
VALUES
    ('viga a23', '2025-01-10', 1.20, 300, 'ATIVA', 1),   
    ('pilar b14', '2025-01-12', 4.80, 220, 'ATIVA', 1),
    ('laje l30', '2025-02-01', 2.50, 500, 'ATIVA', 2), 
    ('viga a45', '2025-01-15', 1.40, 330, 'ATIVA', 1),
    ('pilar c09', '2025-01-18', 0.75, 210, 'ATIVA', 1),
    ('painel p55', '2025-01-20', 3.10, 620, 'ATIVA', 1),
    ('laje l22', '2025-02-05', 2.10, 430, 'INATIVA', 2),
    ('viga a12', '2025-01-09', 1.00, 280, 'ATIVA', 1), 
    ('pilar d07', '2025-02-03', 0.95, 250, 'ATIVA', 2), 
    ('painel p33', '2025-02-10', 2.80, 570, 'INATIVA', 2),
    ('base b10', '2025-01-25', 1.90, 410, 'ATIVA', 1),
    ('sapata s03', '2025-01-27', 3.80, 760, 'ATIVA', 2), 
    ('módulo m18', '2025-02-12', 1.60, 340, 'ATIVA', 1), 
    ('viga a51', '2025-02-14', 1.55, 350, 'ATIVA', 2), 
    ('pilar e11', '2025-02-16', 2.88, 230, 'ATIVA', 1); 

INSERT INTO acabamentos (id_peca, data_inicio, data_fim, status, id_regiao)
VALUES
    (1, '2025-01-15', '2025-01-18', 'FINALIZADO', 1),
    (2, '2025-01-16', '2025-01-19', 'EM_PRODUCAO', 2),
    (3, '2025-02-05', '2025-02-08', 'PENDENTE', 1),
    (4, '2025-01-18', '2025-01-21', 'FINALIZADO', 2),
    (5, '2025-01-19', '2025-01-22', 'EM_PRODUCAO', 1),
    (6, '2025-01-22', '2025-01-25', 'FINALIZADO', 2),
    (7, '2025-02-06', '2025-01-26', 'FINALIZADO', 1),
    (8, '2025-01-10', '2025-02-09', 'FINALIZADO', 1),
    (9, '2025-02-04', '2025-01-13', 'FINALIZADO', 2),
    (10, '2025-02-11', '2025-02-07', 'PENDENTE', 1),
    (11, '2025-01-26', '2025-02-14', 'FINALIZADO', 2),
    (12, '2025-01-28', '2025-01-29', 'EM_PRODUCAO', 1),
    (13, '2025-02-13', '2025-02-16', 'FINALIZADO', 2),
    (14, '2025-02-15', '2025-02-18', 'FINALIZADO', 1),
    (15, '2025-02-17', '2025-02-20', 'FINALIZADO', 2);

INSERT INTO estoques (id_peca, id_acabamento, id_regiao, total, data, status)
VALUES
    (1,  1, 1, 4, '2025-01-20', 'DISPONIVEL'),
    (2,  2, 2, 10, '2025-01-22', 'EM_ACABAMENTO'),
    (3,  3, 3, 50, '2025-02-10', 'AGUARDANDO_ACABAMENTO'),
    (4,  4, 4, 250, '2025-01-20', 'DISPONIVEL'),
    (5,  5, 1, 300, '2025-01-22', 'EM_ACABAMENTO'),
    (6,  6, 2, 23, '2025-01-23', 'DISPONIVEL'),
    (7,  7, 3, 900, '2025-02-07', 'DISPONIVEL'),
    (8,  8, 4, 223, '2025-01-11', 'DISPONIVEL'),
    (9,  9, 1, 232, '2025-02-05', 'DISPONIVEL'),
    (10, 10, 2, 125, '2025-02-12', 'AGUARDANDO_ACABAMENTO'),
    (11, 11, 3, 5, '2025-01-27', 'DISPONIVEL'),
    (12, 12, 4, 90, '2025-01-29', 'EM_ACABAMENTO'),
    (13, 13, 1, 66, '2025-02-14', 'DISPONIVEL'),
    (14, 14, 2, 26, '2025-02-16', 'DISPONIVEL'),
    (15, 15, 3, 11, '2025-02-18', 'DISPONIVEL');