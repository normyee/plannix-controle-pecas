using ControlePecas.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ControlePecas.Repositories
{
    public class BuscarObrasRepo
    {

        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<Obra> Executar()
        {
            var obras = new List<Obra>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                id_obra, 
                                nome_obra, 
                                sigla_obra, 
                                data_entrega, 
                                status 
                              FROM obras";

                using (var cmd = new SqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        obras.Add(new Obra
                        {
                            CodObra = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Sigla = reader.GetString(2),
                            DataEntrega = reader.GetDateTime(3),
                            Status = reader.GetString(4),
                        });
                    }
                }


                return obras;
            }
        }
    }
}
