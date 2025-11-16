using System;
using System.Data.SqlClient;

namespace ControlePecas.Repository
{
    public class ObterPecaRepository
    {
        private readonly string _connectionString =
            "server=localhost,1433;database=master;user id=sa;password=ControlePecas@2025;TrustServerCertificate=true;";

        public PecaObra Executar(int idPeca)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
    select 
        p.id_peca,
        p.nome_peca,
        p.data as data_peca,
        p.status as status_peca,
        p.peso_kg,
        p.volume_mcub,
        p.id_obra,

        a.status as acabamento_status,
        a.data_inicio as acabamento_inicio,
        a.data_fim as acabamento_fim,
        a.id_regiao as setor_acabamento,

        e.total as estoque_total,
        e.data as data_estoque,
        e.status as estoque_status,
        e.id_regiao as regiao_estoque

    from pecas p
    left join acabamentos a on a.id_peca = p.id_peca
    left join estoques e on e.id_peca = p.id_peca
    where p.id_peca = @idPeca";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idPeca", idPeca);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        var peca = new PecaObra
                        {
                            CodControle = reader["id_peca"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id_peca"]),
                            NomePeca = reader["nome_peca"].ToString(),
                            DataPeca = (DateTime)reader["data_peca"],
                            PecaStatus = reader["status_peca"].ToString(),
                            PesoKg = reader["peso_kg"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["peso_kg"]),
                            VolumeM3 = reader["volume_mcub"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["volume_mcub"]),
                            CodObra = reader["id_obra"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id_obra"]),

                            AcabamentoStatus = reader["acabamento_status"].ToString(),
                            AcabamentoDataInicio = (DateTime)reader["acabamento_inicio"],
                            AcabamentoDataFim = (DateTime)reader["acabamento_fim"],
                            SetorAcabamento = reader["setor_acabamento"] == DBNull.Value ? 0 : Convert.ToInt32(reader["setor_acabamento"]),

                            EstoqueTotal = reader["estoque_total"] == DBNull.Value ? 0 : Convert.ToInt32(reader["estoque_total"]),
                            DataEstoque = (DateTime)reader["data_estoque"],
                            EstoqueStatus = reader["estoque_status"].ToString(),
                            RegiaoEstoque = reader["regiao_estoque"] == DBNull.Value ? 0 : Convert.ToInt32(reader["regiao_estoque"])
                        };

                        return peca;
                    }
                }
            }
        }
    }
}
