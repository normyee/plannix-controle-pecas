using ControlePecas.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ControlePecas.Repositories
{
    public class BuscarRegioesEstoquesRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<Regiao> Executar()
        {
            var regioes = new List<Regiao>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                id_regiao, nome
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
                        });

                    }

                }

                return regioes;
            }
        }
    }
}