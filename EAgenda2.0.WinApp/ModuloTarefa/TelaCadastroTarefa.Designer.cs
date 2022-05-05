namespace EAgenda2._0.WinApp
{
    partial class TelaCadastroTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AtualizarItens = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_AdicionarItens = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AtualizarItens
            // 
            this.btn_AtualizarItens.Location = new System.Drawing.Point(25, 293);
            this.btn_AtualizarItens.Name = "btn_AtualizarItens";
            this.btn_AtualizarItens.Size = new System.Drawing.Size(160, 44);
            this.btn_AtualizarItens.TabIndex = 17;
            this.btn_AtualizarItens.Text = "Atualizar Itens";
            this.btn_AtualizarItens.UseVisualStyleBackColor = true;
            this.btn_AtualizarItens.Click += new System.EventHandler(this.btn_AtualizarItens_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(25, 169);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(160, 44);
            this.btn_Excluir.TabIndex = 16;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_AdicionarItens
            // 
            this.btn_AdicionarItens.Location = new System.Drawing.Point(25, 234);
            this.btn_AdicionarItens.Name = "btn_AdicionarItens";
            this.btn_AdicionarItens.Size = new System.Drawing.Size(160, 44);
            this.btn_AdicionarItens.TabIndex = 15;
            this.btn_AdicionarItens.Text = "Adicionar Itens";
            this.btn_AdicionarItens.UseVisualStyleBackColor = true;
            this.btn_AdicionarItens.Click += new System.EventHandler(this.btn_AdicionarItens_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(25, 100);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(160, 44);
            this.btn_Editar.TabIndex = 14;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(25, 38);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(160, 44);
            this.btn_Inserir.TabIndex = 12;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(215, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 364);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 20;
            this.listTarefasPendentes.Location = new System.Drawing.Point(32, 33);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(599, 264);
            this.listTarefasPendentes.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 20;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(32, 33);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(599, 264);
            this.listTarefasConcluidas.TabIndex = 20;
            // 
            // TelaCadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 438);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_AtualizarItens);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_AdicionarItens);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.TelaCadastroTarefa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AtualizarItens;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_AdicionarItens;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
    }
}