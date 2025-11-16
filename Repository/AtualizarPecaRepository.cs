using System;
using System.Data;
using System.Data.SqlClient;

namespace ControlePecas.Repository
{
    public class AtualizarPecaRepository
    {
        private readonly string _connectionString =
            "server=localhost,1433;database=master;user id=sa;password=ControlePecas@2025;TrustServerCertificate=true;";

        public void Executar(int codControle, PecaObra peca)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        AtualizarPeca(connection, transaction, codControle, peca);
                        AtualizarAcabamento(connection, transaction, codControle, peca);
                        AtualizarEstoque(connection, transaction, codControle, peca);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        private void AtualizarPeca(SqlConnection connection, SqlTransaction transaction, int idPeca, PecaObra peca)
        {
            string query = @"
                update pecas
                set nome_peca = @nomePeca,
                    data = isnull(@dataPeca, getdate()),
                    volume_mcub = @volumeMcub,
                    peso_kg = @pesoKg,
                    status = @statusPeca,
                    id_obra = @codObra
                where id_peca = @idPeca;";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@idPeca", idPeca);
                cmd.Parameters.Add("@nomePeca", SqlDbType.NVarChar, 255).Value = peca.NomePeca;
                cmd.Parameters.Add("@dataPeca", SqlDbType.Date).Value = (object)peca.DataPeca ?? DBNull.Value;

                var pVolume = cmd.Parameters.Add("@volumeMcub", SqlDbType.Decimal);
                pVolume.Precision = 10;
                pVolume.Scale = 2;
                pVolume.Value = peca.VolumeM3;

                var pPeso = cmd.Parameters.Add("@pesoKg", SqlDbType.Decimal);
                pPeso.Precision = 10;
                pPeso.Scale = 2;
                pPeso.Value = peca.PesoKg;

                cmd.Parameters.Add("@statusPeca", SqlDbType.VarChar, 30).Value = peca.PecaStatus;
                cmd.Parameters.Add("@codObra", SqlDbType.Int).Value = peca.CodObra;

                cmd.ExecuteNonQuery();
            }
        }

        private void AtualizarAcabamento(SqlConnection connection, SqlTransaction transaction, int idPeca, PecaObra peca)
        {
            string query = @"
        update acabamentos
        set data_inicio = @dataInicio,
            data_fim = @dataFim,
            status = @status,
            id_regiao = @setorAcabamento
        where id_peca = @idPeca;";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@idPeca", idPeca);
                cmd.Parameters.AddWithValue("@dataInicio", (object)peca.AcabamentoDataInicio ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@dataFim", (object)peca.AcabamentoDataFim ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@status", peca.AcabamentoStatus);
                cmd.Parameters.AddWithValue("@setorAcabamento", peca.SetorAcabamento);

                cmd.ExecuteNonQuery();
            }
        }

        private void AtualizarEstoque(SqlConnection connection, SqlTransaction transaction, int idPeca, PecaObra peca)
        {
            string query = @"
        update estoques
        set data = @dataEstoque,
            id_regiao = @regiaoEstoque,
            total = @total,
            status = @status
        where id_peca = @idPeca;";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@idPeca", idPeca);
                cmd.Parameters.Add("@dataEstoque", SqlDbType.Date).Value = (object)peca.DataEstoque ?? DBNull.Value;
                cmd.Parameters.Add("@regiaoEstoque", SqlDbType.Int).Value = peca.RegiaoEstoque;
                cmd.Parameters.Add("@total", SqlDbType.Int).Value = peca.EstoqueTotal;
                cmd.Parameters.Add("@status", SqlDbType.VarChar, 30).Value = peca.EstoqueStatus;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
