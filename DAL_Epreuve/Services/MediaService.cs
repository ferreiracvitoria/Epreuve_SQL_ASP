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
    public class MediaService : BaseService, IMediaRepository<Media>
    {
        public MediaService(IConfiguration configuration) : base(configuration, "Epreuve_SQL_ASP")
        {
        }

        public IEnumerable<Media> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Media Media = reader.ToMedia();
                            yield return Media;

                        };
                    }
                }
            }
        }
        public Media Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Media", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToMedia();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la BD");

                    }
                }
            }
        }
        public int Insert(Media data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Media);
                    command.Parameters.AddWithValue("id_produit", data.Id_Produit);
                    command.Parameters.AddWithValue("urlImage", data.UrlImage);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public void Update(Media data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Media);
                    command.Parameters.AddWithValue("id_produit", data.Id_Produit);
                    command.Parameters.AddWithValue("urlImage", data.UrlImage);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Media), $"L'identifiant {data.Id_Media} n'est pas das la BD");
                }
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Delete";
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
