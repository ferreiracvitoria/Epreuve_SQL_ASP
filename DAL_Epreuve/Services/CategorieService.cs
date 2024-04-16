using DAL_Epreuve.Entities;
using DAL_Epreuve.Mappers;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL_Epreuve.Services
{
    public class CategorieService : BaseService, ICategorieRepository<Categorie>
    {
        public CategorieService(IConfiguration configuration) : base(configuration, "Epreuve_SQL_ASP")
        {
        }

        public IEnumerable<Categorie> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Categorie]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategorie();
                        }
                    }
                }
            }
        }
    }
}
