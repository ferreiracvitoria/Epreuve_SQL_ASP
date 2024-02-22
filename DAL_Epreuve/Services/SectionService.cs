using DAL_Epreuve.Entities;
using DAL_Epreuve.Mappers;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Epreuve.Services
{
    public class SectionService : BaseService, ISectionRepository<Section>
    {
        public SectionService(IConfiguration configuration) : base(configuration, "Epreuve_SQL_ASP")
        {
        }

        public IEnumerable<Section> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Section_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Section Section = reader.ToSection();
                            yield return Section;
                        };
                    }
                }
            }
        }
        public Section Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Section_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Section", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToSection();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la BD");

                    }
                }
            }
        }
        public int Insert(Section data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Section_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Section);
                    command.Parameters.AddWithValue("id_Commande", data.Id_Commande);
                    command.Parameters.AddWithValue("id_Produit", data.Id_Produit);
                    command.Parameters.AddWithValue("quantite", data.Quantite);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public void Update(Section data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Section_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Section);
                    command.Parameters.AddWithValue("id_Commande", data.Id_Commande);
                    command.Parameters.AddWithValue("id_Produit", data.Id_Produit);
                    command.Parameters.AddWithValue("quantite", data.Quantite);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Section), $"L'identifiant {data.Id_Section} n'est pas das la BD");
                }
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Section_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la BD");
                }
            }
        }
    }
}
