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
    internal class CommandeService : BaseService, ICommandeRepository<Commande>
    {
        public CommandeService(IConfiguration configuration) : base(configuration, "Epreuve_SQL_ASP")
        {
        }

        public IEnumerable<Commande> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Commande_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Commande Commande = reader.ToCommande();
                            yield return Commande;

                        };
                    }
                }
            }
        }
        public Commande Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Commande_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Commande", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCommande();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la BD");

                    }
                }
            }
        }
        public int Insert(Commande data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Commande_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Commande);
                    command.Parameters.AddWithValue("dateCommande", data.DateCommande);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public void Update(Commande data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Commande_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Commande);
                    command.Parameters.AddWithValue("dateCommande", data.DateCommande);
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Commande), $"L'identifiant {data.Id_Commande} n'est pas das la BD");
                }
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Commande_Delete";
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
