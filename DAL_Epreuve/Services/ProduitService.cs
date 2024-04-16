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
    public class ProduitService : BaseService, IProduitRepository<Produit>
    {
        public ProduitService(IConfiguration configuration) : base(configuration, "Epreuve_SQL_ASP")
        {
        }

        public IEnumerable<Produit> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produit Produit = reader.ToProduit();
                            yield return Produit;
                            
                        };
                    }
                }
            }
        }
        
        public IEnumerable<Produit> GetByCategorie(string categorie)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetByCategorie";
                    command.Parameters.AddWithValue("Categorie", categorie);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        public IEnumerable<Produit> GetByCritere(string critereEco)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetByCritere";
                    command.Parameters.AddWithValue("CritereEcologique", critereEco);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        public IEnumerable<Produit> GetByNom(string nomProduit)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetByNom";
                    command.Parameters.AddWithValue("NomProduit", nomProduit);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }
        public Produit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Produit", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la BD");

                    }
                }
            }
        }
        public int Insert(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Produit);
                    command.Parameters.AddWithValue("Categorie", data.Categorie);
                    command.Parameters.AddWithValue("CritereEcologique", data.CritereEcologique);
                    command.Parameters.AddWithValue("nom", data.Nom);
                    command.Parameters.AddWithValue("description", data.Description);
                    command.Parameters.AddWithValue("prix", data.Prix);
                    command.Parameters.AddWithValue("stock", data.Stock);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public void Update(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", data.Id_Produit);
                    command.Parameters.AddWithValue("Categorie", data.Categorie);
                    command.Parameters.AddWithValue("CritereEcologique", data.CritereEcologique);
                    command.Parameters.AddWithValue("nom", data.Nom);
                    command.Parameters.AddWithValue("description", data.Description);
                    command.Parameters.AddWithValue("prix", data.Prix);
                    command.Parameters.AddWithValue("stock", data.Stock);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Produit), $"L'identifiant {data.Id_Produit} n'est pas das la BD");
                }
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Delete";
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
