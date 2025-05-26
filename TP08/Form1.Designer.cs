namespace TP08
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.txCadastrarNome = new System.Windows.Forms.TextBox();
            this.btCadastrarNome = new System.Windows.Forms.Button();
            this.txCadastrarData = new System.Windows.Forms.TextBox();
            this.txCadastrarStatus = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btDeletarTarefa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Location = new System.Drawing.Point(12, 12);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.Size = new System.Drawing.Size(416, 275);
            this.dgvTarefas.TabIndex = 0;
            // 
            // txCadastrarNome
            // 
            this.txCadastrarNome.Location = new System.Drawing.Point(505, 99);
            this.txCadastrarNome.Name = "txCadastrarNome";
            this.txCadastrarNome.Size = new System.Drawing.Size(100, 20);
            this.txCadastrarNome.TabIndex = 1;
            // 
            // btCadastrarNome
            // 
            this.btCadastrarNome.Location = new System.Drawing.Point(505, 264);
            this.btCadastrarNome.Name = "btCadastrarNome";
            this.btCadastrarNome.Size = new System.Drawing.Size(100, 23);
            this.btCadastrarNome.TabIndex = 2;
            this.btCadastrarNome.Text = "Cadastrar Tarefa";
            this.btCadastrarNome.UseVisualStyleBackColor = true;
            this.btCadastrarNome.Click += new System.EventHandler(this.btCadastrarNome_Click);
            // 
            // txCadastrarData
            // 
            this.txCadastrarData.Location = new System.Drawing.Point(649, 99);
            this.txCadastrarData.Name = "txCadastrarData";
            this.txCadastrarData.Size = new System.Drawing.Size(100, 20);
            this.txCadastrarData.TabIndex = 3;
            // 
            // txCadastrarStatus
            // 
            this.txCadastrarStatus.Location = new System.Drawing.Point(797, 99);
            this.txCadastrarStatus.Name = "txCadastrarStatus";
            this.txCadastrarStatus.Size = new System.Drawing.Size(100, 20);
            this.txCadastrarStatus.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(511, 73);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(84, 13);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome da Tarefa";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(660, 73);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(79, 13);
            this.lbData.TabIndex = 7;
            this.lbData.Text = "Data da Tarefa";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(807, 73);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(86, 13);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Status da Tarefa";
            // 
            // btDeletarTarefa
            // 
            this.btDeletarTarefa.Location = new System.Drawing.Point(649, 264);
            this.btDeletarTarefa.Name = "btDeletarTarefa";
            this.btDeletarTarefa.Size = new System.Drawing.Size(100, 23);
            this.btDeletarTarefa.TabIndex = 9;
            this.btDeletarTarefa.Text = "Excluir Tarefa";
            this.btDeletarTarefa.UseVisualStyleBackColor = true;
            this.btDeletarTarefa.Click += new System.EventHandler(this.btDeletarTarefa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 602);
            this.Controls.Add(this.btDeletarTarefa);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txCadastrarStatus);
            this.Controls.Add(this.txCadastrarData);
            this.Controls.Add(this.btCadastrarNome);
            this.Controls.Add(this.txCadastrarNome);
            this.Controls.Add(this.dgvTarefas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.TextBox txCadastrarNome;
        private System.Windows.Forms.Button btCadastrarNome;
        private System.Windows.Forms.TextBox txCadastrarData;
        private System.Windows.Forms.TextBox txCadastrarStatus;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btDeletarTarefa;
    }
}

