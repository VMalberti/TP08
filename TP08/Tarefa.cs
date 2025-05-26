using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP08
{
    internal class Tarefa
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
    }



    internal class TarefaController
    {
        private Connection conn;

        public TarefaController()
        {
            // Defina a string de conexão de acordo com o seu ambiente
            string connectionString = "Server=localhost\\DESKTOP-HPUUT5J;Database=tp8;Integrated Security=True;";
            conn = new Connection(connectionString);
        }

        public string cadastarTarefa(string nome, string data, string status)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(data) || string.IsNullOrEmpty(status))
                return "Nome, Data e Status são obrigatórios.";

            if (!DateTime.TryParse(data, out DateTime DataConvertida))
                return "Data inválida.";

            Tarefa tarefa = new Tarefa
            {
                Nome = nome,
                Data = DataConvertida,
                Status = status
            };

            try
            {
                conn.SetTarefa(tarefa);
                return "Tarefa salva com sucesso no banco de dados!";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar no banco: " + ex.Message;
            }
        }

        public List<Tarefa> obterTarefas()
        {
            try
            {
                return conn.GetTarefas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter tarefas: " + ex.Message);
                return new List<Tarefa>();
            }
        }

        public string removerTarefa(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return "O nome da tarefa é obrigatório para remoção.";

            try
            {
                conn.RemoverTarefa(nome);
                return "Tarefa removida com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao remover tarefa: " + ex.Message;
            }
        }
    }





}
