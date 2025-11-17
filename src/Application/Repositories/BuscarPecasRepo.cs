using ControlePecas.Domain;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ControlePecas.Repository
{
    public class BuscarPecasRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<PecaItem> Executar(int codObra, int idRegiao)
        {
            var pecaItens = new List<PecaItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
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
                    on r.id_regiao = e.id_regiao
                where (@codObra = 0 or o.id_obra = @codObra)
                  and (@idRegiao = 0 or r.id_regiao = @idRegiao);
            ";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@codObra", codObra);
                    cmd.Parameters.AddWithValue("@idRegiao", idRegiao);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pecaItens.Add(new PecaItem
                            {
                                CodigoControle = reader.GetInt32(0),
                                Peca = reader.GetString(1),
                                Obra = reader.GetString(2),
                                StatusAcabamento = reader.GetString(3),
                                RegiaoEstoque = reader.GetString(4)
                            });
                        }
                    }
                }

                return pecaItens;
            }
        }

    }
}
