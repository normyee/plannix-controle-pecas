using ControlePecas.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ControlePecas.Repository
{
    public class BuscarRegioesEstoquesRepository
    {
        private readonly string _connectionString = "server=localhost,1433;database=master;user id=sa;password=ControlePecas@2025;TrustServerCertificate=true;";

        public List<Regiao> Executar()
        {
            var regioes = new List<Regiao>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                id_regiao, 
                                nome_regiao, 
                                tipo_regiao, 
                              FROM regioes";

                using (var cmd = new SqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        regioes.Add(new Regiao()
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Tipo = reader.GetString(2)
                        });

                    }

                }

                return regioes;
            }
        }
    }
}