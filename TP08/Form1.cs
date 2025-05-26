using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;
using System.Data.SqlClient;

namespace TP08
{
    public partial class Form1 : Form
    {

        Connection conn;
        private TarefaController controller = new TarefaController();
        


        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=localhost\\DESKTOP-HPUUT5J;Database=tp8;Integrated Security=True;";
            conn = new Connection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void AtualizarTarefa()
        {
            List<Tarefa> tarefas = controller.obterTarefas();
            dgvTarefas.DataSource = null;
            dgvTarefas.DataSource = tarefas;
        }

        private void btCadastrarNome_Click(object sender, EventArgs e)
        {
            string nome = txCadastrarNome.Text;
            string data = txCadastrarData.Text;
            string status = txCadastrarStatus.Text;

            string mensagem = controller.cadastarTarefa(nome, data, status);
            MessageBox.Show(mensagem);

            AtualizarTarefa();

        }

        private void btDeletarTarefa_Click(object sender, EventArgs e)
        {
            string nome = txCadastrarNome.Text;
            string data = txCadastrarData.Text;
            string status = txCadastrarStatus.Text;

            string mensagem = controller.removerTarefa(nome);
            MessageBox.Show(mensagem);

            AtualizarTarefa();
        }
        private void TestarConexao()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost\\DESKTOP-HPUUT5J;Database=tp8;Integrated Security=True;"))
                {
                    connection.Open();
                    MessageBox.Show("Conexão bem-sucedida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão: " + ex.Message);
            }
        }

    }
}
