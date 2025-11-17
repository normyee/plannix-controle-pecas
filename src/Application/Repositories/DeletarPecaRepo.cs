using System.Configuration;
using System.Data.SqlClient;

namespace ControlePecas.Repositories
{
    public class DeletarPecaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
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
