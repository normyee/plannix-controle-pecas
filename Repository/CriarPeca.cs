using System;
using System.Data;
using System.Data.SqlClient;

namespace ControlePecas.Repository
{
    public class PecaObra
    {
        public string NomePeca { get; set; }
        public DateTime? DataPeca { get; set; }   
        public string PecaStatus { get; set; }
        public decimal PesoKg { get; set; }       
        public decimal VolumeM3 { get; set; }         
        public int RegiaoEstoque { get; set; }         
 
        public string AcabamentoStatus { get; set; }     
        public DateTime? AcabamentoDataInicio { get; set; }  
        public DateTime? AcabamentoDataFim { get; set; }   
        public int SetorAcabamento { get; set; }

        public int EstoqueTotal { get; set; }            
        public DateTime? DataEstoque { get; set; }       
        public string EstoqueStatus { get; set; }      

        public int CodObra { get; set; }             
    }

    public class CriarPecaRepository
    {

        private readonly string _connectionString = "server=localhost,1433;database=master;user id=sa;password=ControlePecas@2025;TrustServerCertificate=true;";
    
        public object Executar(PecaObra peca)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int idPeca = InserirPeca(connection, transaction, peca);
                        int idAcabamento = InserirAcabamento(connection, transaction, idPeca, peca);
                        InserirEstoque(connection, transaction, idPeca, idAcabamento, peca);

                        transaction.Commit();

                        return new object();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }


                
        }

        private int InserirPeca(SqlConnection connection, SqlTransaction transaction, PecaObra peca)
        {
            string query = @"
        insert into pecas (nome_peca, data, volume_mcub, peso_kg, status, id_obra)
        values (@nomePeca, isnull(@dataPeca, getdate()), @volumeMcub, @pesoKg, @statusPeca, @codObra);
        select scope_identity();";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.Add("@nomePeca", SqlDbType.NVarChar, 255).Value = peca.NomePeca;

                cmd.Parameters.Add("@dataPeca", SqlDbType.Date).Value =
                    (object)peca.DataPeca ?? DBNull.Value;

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

                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }


        private int InserirAcabamento(SqlConnection connection, SqlTransaction transaction, int idPeca, PecaObra peca)
        {
            string query = @"
                insert into acabamentos (id_peca, data_inicio, data_fim, status, id_regiao)
                values (@idPeca, @dataInicio, @dataFim, @status, @setorAcabamento);
                select scope_identity();";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@idPeca", idPeca);
                cmd.Parameters.AddWithValue("@dataInicio", peca.AcabamentoDataInicio);
                cmd.Parameters.AddWithValue("@dataFim", peca.AcabamentoDataFim);
                cmd.Parameters.AddWithValue("@status", peca.AcabamentoStatus);
                cmd.Parameters.AddWithValue("@setorAcabamento", peca.SetorAcabamento);
            
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        private void InserirEstoque(SqlConnection connection, SqlTransaction transaction, int idPeca, int idAcabamento, PecaObra peca)
        {
            string query = @"
        insert into estoques (id_peca, id_acabamento, data, id_regiao, total, status)
        values (@idPeca, @idAcabamento, @dataEstoque, @regiaoEstoque, @total, @status);";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.Add("@idPeca", SqlDbType.Int).Value = idPeca;
                cmd.Parameters.Add("@idAcabamento", SqlDbType.Int).Value = idAcabamento;
                cmd.Parameters.Add("@dataEstoque", SqlDbType.Date).Value = peca.DataEstoque.Value;
                cmd.Parameters.Add("@regiaoEstoque", SqlDbType.Int).Value = peca.RegiaoEstoque;
                cmd.Parameters.Add("@total", SqlDbType.Int).Value = peca.EstoqueTotal;
                cmd.Parameters.Add("@status", SqlDbType.VarChar, 30).Value = peca.EstoqueStatus;

                cmd.ExecuteNonQuery();
            }
        }

    }
}
