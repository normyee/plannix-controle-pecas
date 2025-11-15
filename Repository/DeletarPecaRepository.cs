using System.Data.SqlClient;

namespace ControlePecas.Repository
{
    public class DeletarPecaRepository
    {
        private readonly string _connectionString =
            "server=localhost,1433;database=master;user id=sa;password=ControlePecas@2025;TrustServerCertificate=true;";

        public void Executar(int codControle)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "delete from pecas where id_peca = @codControle";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@codControle", codControle);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
