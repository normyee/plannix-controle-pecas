SELECT 
  p.id_peca AS codigo_controle,
  p.nome_peca,
  o.nome_obra,
  a.status AS status_acabamento,
  re.nome_regiao AS regiao_estoque
FROM pecas p
JOIN obras o    ON o.id_obra = p.id_obra
JOIN acabamentos a 
                ON a.id_peca = p.id_peca
JOIN estoques e 
                ON e.id_peca = p.id_peca
                AND e.id_acabamento = a.id_acabamento
JOIN regioes re ON re.id_regiao = e.id_regiao;