using System.Data.SqlClient;
using System;
using System.Collections.Generic;


namespace TP08
{
    internal class Connection
    {
        private string connectionString;

        public Connection(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void SetTarefa(Tarefa tarefa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tb_tarefas (nome, data, status) VALUES (@nome, @data, @status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                    cmd.Parameters.AddWithValue("@data", tarefa.Data);
                    cmd.Parameters.AddWithValue("@status", tarefa.Status);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro: {ex.Message}");
                }
            }
        }

        public List<Tarefa> GetTarefas()
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nome, data, status FROM tb_tarefas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tarefas.Add(new Tarefa
                            {
                                Nome = reader.GetString(0),
                                Data = reader.GetDateTime(1),
                                Status = reader.GetString(2)
                            });
                        }
                    }
                    return tarefas;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void RemoverTarefa(string nome)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM tb_tarefas WHERE nome = @nome";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        throw new Exception("Tarefa não encontrada.");
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro ao remover tarefa: {ex.Message}");
                }
            }
        }

    }
}