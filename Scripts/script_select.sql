select
    p.id_peca as codigo_controle,
    p.nome_peca,
    o.nome_obra,
    a.status as status_acabamento,
    r.nome as regiao_estoque
from pecas p
join obras o
    on o.id_obra = p.id_obra
join acabamentos a
    on a.id_peca = p.id_peca
join estoques e
    on e.id_peca = p.id_peca
    and e.id_acabamento = a.id_acabamento
join regioes r
    on r.id_regiao = e.id_regiao;
